using FreelancePlatform.Class;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FreelancePlatform
{
    public partial class frmPostProjectForm : Form
    {
        DataConnection dbObj = new DataConnection();
        private int clientId, currentUserID;
        private ProjectNotifier projectNotifier;

        public frmPostProjectForm(int clientId, ProjectNotifier notifier)
        {
            InitializeComponent();
            this.clientId = clientId;
            this.projectNotifier = notifier;

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

        private void btnPostProject_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string description = txtDescription.Text;
            string requiredSkills = txtRequiredSkills.Text.Trim().ToLower(); // Normalize for matching

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(requiredSkills) || !decimal.TryParse(txtBudget.Text, out decimal budget) ||
                !DateTime.TryParse(txtDeadline.Text, out DateTime deadline))
            {
                MessageBox.Show("Please enter valid project details.");
                return;
            }

            string status = "open";
            string query = "INSERT INTO project (client_id, title, description, budget, deadline, requiredSkills, status) " +
                          "VALUES (@ClientId, @Title, @Description, @Budget, @Deadline, @RequiredSkills, @Status)";
            int result = dbObj.ExecuteNonQuery(query,
                ("@ClientId", clientId),
                ("@Title", title),
                ("@Description", description),
                ("@Budget", budget),
                ("@Deadline", deadline),
                ("@RequiredSkills", requiredSkills),
                ("@Status", status));

            if (result > 0)
            {
                MessageBox.Show("Project posted successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to post project.");
            }
        }


        private void frmPostProjectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmClientDashboard clientDashboard = new frmClientDashboard(currentUserID);
            clientDashboard.ShowDialog();
        }
    }
}