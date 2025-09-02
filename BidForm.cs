using FreelancePlatform.Class;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FreelancePlatform
{
    public partial class BidForm : Form
    {
        DataConnection dbObj = new DataConnection();
        private int freelancerId;
        private int projectId;

        public BidForm(int projectId, int freelancerId)
        {
            InitializeComponent();
            this.projectId = projectId;
            this.freelancerId = freelancerId;
        }

        private void btnSubmitBid_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate bid amount
                if (!decimal.TryParse(txtBidAmount.Text, out decimal bidAmount) || bidAmount <= 0)
                {
                    MessageBox.Show("Please enter a valid bid amount (positive number).");
                    return;
                }

                // Validate estimated days
                if (!int.TryParse(txtEstimatedDays.Text, out int estimatedDays) || estimatedDays <= 0)
                {
                    MessageBox.Show("Please enter a valid number of estimated days (positive integer).");
                    return;
                }

                // Open database connection
                dbObj.cnOpen();

                // Insert the bid into the database
                string query = "INSERT INTO bid (freelancer_id, project_id, bid_amount, estimated_days, status) " +
                               "VALUES (@FreelancerId, @ProjectId, @BidAmount, @EstimatedDays, 'Pending')";
                int result = dbObj.ExecuteNonQuery(query,
                    ("@FreelancerId", freelancerId),
                    ("@ProjectId", projectId),
                    ("@BidAmount", bidAmount),
                    ("@EstimatedDays", estimatedDays));

                if (result > 0)
                {
                    // Update project table with the freelancer_id of the submitted bid
                    query = "UPDATE project SET freelancer_id = @FreelancerId WHERE project_id = @ProjectId";
                    int updateResult = dbObj.ExecuteNonQuery(query,
                        ("@FreelancerId", freelancerId),
                        ("@ProjectId", projectId));
                    string clientQuery = "SELECT client_id FROM project WHERE project_id = @ProjectId";
                    MySqlDataReader dr = dbObj.ExecuteReader(clientQuery, ("@ProjectId", projectId));
                    int clientId = 0;

                    if (updateResult > 0)
                    {
                        MessageBox.Show("Bid submitted successfully! Project updated with your freelancer ID.");
                    }
                    else
                    {
                        MessageBox.Show("Bid submitted, but failed to update project with freelancer ID.");
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to submit bid.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error submitting bid: {ex.Message}");
            }
            finally
            {
                dbObj.cnClose();
            }
        }
        
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Indicate cancellation
            this.Close();
        }

        private void BidForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // No need to create a new frmFreelancerDashboard here
            // The calling form (frmFreelancerDashboard) will handle its own visibility
        }

    }
}