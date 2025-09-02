using FreelancePlatform.Class;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FreelancePlatform
{
    public partial class ReviewBidsForm : Form
    {
        DataConnection dbObj = new DataConnection();
        private int clientId, currentUserID;
        private int projectId;
        private int bidId;
        private int freelancerId;

        public ReviewBidsForm(int clientId, int projectId)
        {
            InitializeComponent();
            this.clientId = clientId;
            this.projectId = projectId;

            dbObj.cnOpen();
            string query = "SELECT user_id FROM client WHERE client_id = @ClientId";
            MySqlDataReader dr = dbObj.ExecuteReader(query, ("@ClientId", clientId));

            if (dr.Read())
            {
                currentUserID = Convert.ToInt32(dr["user_id"]);
                LoadBids();
            }
            else
            {
                dr.Close();
                MessageBox.Show("Client not found.");
                dbObj.cnClose();
                return;
            }
            dr.Close();
            dbObj.cnClose();
        }

        private void LoadBids()
        {
            dbObj.cnOpen();
            string query = "SELECT bid_id, freelancer_id, bid_amount, estimated_days, status FROM bid WHERE project_id = @ProjectId";
            MySqlDataReader dr = dbObj.ExecuteReader(query, ("@ProjectId", projectId));

            if (dr.Read())
            {
                bidId = Convert.ToInt32(dr["bid_id"]);
                freelancerId = Convert.ToInt32(dr["freelancer_id"]);
                lblBidAmount.Text = dr["bid_amount"].ToString();
                lblEstimatedDays.Text = dr["estimated_days"].ToString();
                lblStatus.Text = dr["status"].ToString();
            }
            else
            {
                MessageBox.Show("No bids found for this project.");
            }
            dr.Close();
            dbObj.cnClose();
        }

      
        private void btnAccept_Click(object sender, EventArgs e)
        {
            dbObj.cnOpen();
            string query = "UPDATE bid SET status = 'Accepted' WHERE bid_id = @BidId";
            dbObj.ExecuteNonQuery(query, ("@BidId", bidId));

            query = "UPDATE project SET freelancer_id = @FreelancerId, status = 'ongoing' WHERE project_id = @ProjectId";
            dbObj.ExecuteNonQuery(query, ("@FreelancerId", freelancerId), ("@ProjectId", projectId));

            MessageBox.Show("Bid accepted! Project assigned to freelancer.");
            LoadBids();
            dbObj.cnClose();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            dbObj.cnOpen();
            string query = "UPDATE bid SET status = 'Rejected' WHERE bid_id = @BidId";
            dbObj.ExecuteNonQuery(query, ("@BidId", bidId));

            MessageBox.Show("Bid rejected.");
            LoadBids();
            dbObj.cnClose();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            try
            {
                dbObj.cnOpen();

                // Check project status
                string query = "SELECT status FROM project WHERE project_id = @ProjectId";
                MySqlDataReader dr = dbObj.ExecuteReader(query, ("@ProjectId", projectId));
                string projectStatus = "";
                if (dr.Read())
                {
                    projectStatus = dr["status"].ToString();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Project not found in database.");
                    return;
                }
                dr.Close();

                if (projectStatus != "ongoing")
                {
                    MessageBox.Show($"Cannot complete project. Current status is '{projectStatus}', expected 'Ongoing'.");
                    return;
                }

                // Check bid status
                query = "SELECT status FROM bid WHERE bid_id = @BidId";
                dr = dbObj.ExecuteReader(query, ("@BidId", bidId));
                string bidStatus = "";
                if (dr.Read())
                {
                    bidStatus = dr["status"].ToString();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Bid not found in database.");
                    return;
                }
                dr.Close();

                if (bidStatus != "Accepted")
                {
                    MessageBox.Show($"Cannot complete bid. Current status is '{bidStatus}', expected 'Accepted'.");
                    return;
                }

                // Update project status to "Completed"
                query = "UPDATE project SET status = 'Completed' WHERE project_id = @ProjectId";

                int projectResult = dbObj.ExecuteNonQuery(query, ("@ProjectId", projectId));

                // Update UI even if bid update fails
                if (projectResult > 0)
                {
                    lblStatus.Text = "Completed"; // Update UI label
                    MessageBox.Show("Project marked as completed successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to update project status.");
                    return;
                }

                // Update bid status to "Completed"
                query = "UPDATE bid SET status = 'Completed' WHERE bid_id = @BidId";
                int bidResult = dbObj.ExecuteNonQuery(query, ("@BidId", bidId));

                if (bidResult > 0)
                {
                    MessageBox.Show("Bid status updated to 'Completed'.");
                }
                else
                {
                    MessageBox.Show("Failed to update bid status, but project status was updated.");
                }

                btnComplete.Visible = false;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error completing project: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbObj.cnClose();
            }
        }
        private void ReviewBidsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmClientDashboard clientDashboardForm = new frmClientDashboard(currentUserID);
            clientDashboardForm.ShowDialog();

        }
    }
}