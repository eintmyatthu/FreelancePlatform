using FreelancePlatform.Class;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FreelancePlatform
{
    public partial class LeaveReviewForm : Form
    {
        DataConnection dbObj = new DataConnection();
        private int projectId;
        private int freelancerId;
        private int clientId, currentUserID;

        public LeaveReviewForm(int projectId, int freelancerId, int clientId)
        {
            InitializeComponent();
            this.projectId = projectId;
            this.freelancerId = freelancerId;
            this.clientId = clientId;

            dbObj.cnOpen();
            string query = "SELECT user_id FROM client WHERE client_id = @ClientId";
            MySqlDataReader dr = dbObj.ExecuteReader(query, ("@ClientId", clientId));

            if (dr.Read())
            {
                currentUserID = Convert.ToInt32(dr["user_id"]);
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

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cboRating.Text, out int rating) || rating < 1 || rating > 5)
            {
                MessageBox.Show("Please select a valid rating between 1 and 5.");
                return;
            }

            string reviewText = txtReviewText.Text.Trim();
            if (string.IsNullOrWhiteSpace(reviewText))
            {
                MessageBox.Show("Review text cannot be empty.");
                return;
            }

            string insertQuery = "INSERT INTO review (project_id, freelancer_id, client_id, rating, review_text) " +
                                 "VALUES (@ProjectId, @FreelancerId, @ClientId, @Rating, @ReviewText)";
            int result = dbObj.ExecuteNonQuery(insertQuery,
                ("@ProjectId", projectId),
                ("@FreelancerId", freelancerId),
                ("@ClientId", clientId),
                ("@Rating", rating),
                ("@ReviewText", reviewText));

            if (result > 0)
            {
                MessageBox.Show("Review submitted successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to submit review.");
            }
        }

        private void LeaveReviewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmClientDashboard clientDashboardForm = new frmClientDashboard(currentUserID);
            clientDashboardForm.ShowDialog();
        }
    }
}