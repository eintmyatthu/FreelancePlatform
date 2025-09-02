using FreelancePlatform.Class;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FreelancePlatform
{
    public partial class frmClientDashboard : Form
    {
        DataConnection dbObj = new DataConnection();
        public int currentUserID;
        public int clientId;
        ProjectNotifier notifier = new ProjectNotifier();
        private bool isFormClosing = false; // Flag to prevent reentrant calls

        public frmClientDashboard(int uID)
        {
            InitializeComponent();
            currentUserID = uID;


            try
            {
                dbObj.cnOpen();

                // Validate user_id exists
                string userQuery = "SELECT user_id FROM user WHERE user_id = @UserId";
                MySqlDataReader userDr = dbObj.ExecuteReader(userQuery, ("@UserId", uID));
                if (!userDr.Read())
                {
                    userDr.Close();
                    MessageBox.Show("Invalid user ID. User does not exist.");
                    NavigateToLogin();
                    return;
                }
                userDr.Close();

                // Check if client profile exists
                string query = "SELECT client_id FROM client WHERE user_id = @UserId";
                MySqlDataReader dr = dbObj.ExecuteReader(query, ("@UserId", uID));
                if (dr.Read())
                {
                    clientId = Convert.ToInt32(dr["client_id"]);
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Please create your client profile first.");
                    this.Visible = false;
                    ClientProfileForm profileForm = new ClientProfileForm(0);
                    profileForm.currentUserID = currentUserID;
                    DialogResult result = profileForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        dbObj.cnOpen();
                        MySqlDataReader checkDr = dbObj.ExecuteReader(query, ("@UserId", uID));
                        if (checkDr.Read())
                        {
                            clientId = Convert.ToInt32(checkDr["client_id"]);
                            checkDr.Close();
                        }
                        else
                        {
                            checkDr.Close();
                            MessageBox.Show("Failed to create client profile. Returning to login.");
                            NavigateToLogin();
                        }
                        dbObj.cnClose();
                    }
                    else
                    {
                        MessageBox.Show("Profile creation is mandatory. Returning to login.");
                        NavigateToLogin();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing client dashboard: {ex.Message}");
                NavigateToLogin();
            }
            finally
            {
                dbObj.cnClose();
            }

            // Load projects after initialization
            if (clientId > 0) LoadClientProjects();
        }

        private void NavigateToLogin()
        {
            if (isFormClosing) return;
            isFormClosing = true;

            try
            {
                this.Hide(); // Hide the dashboard
                frmLogin loginForm = new frmLogin();
                loginForm.FormClosed += (s, args) =>
                {
                    Application.Exit(); // Fully exit application
                };
                loginForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating to login: {ex.Message}");
            }
        }
        
        private void LoadClientProjects()
        {
            try
            {
                dbObj.cnOpen();
                string query = @"
            SELECT 
                p.project_id, 
                p.title, 
                p.description, 
                p.budget, 
                p.deadline, 
                p.status, 
                p.freelancer_id AS assigned_freelancer_id,
                (SELECT b.freelancer_id 
                 FROM bid b 
                 WHERE b.project_id = p.project_id 
                 ORDER BY b.bid_id DESC 
                 LIMIT 1) AS latest_bid_freelancer_id
            FROM project p 
            WHERE p.client_id = @ClientId";
                DataTable dt = dbObj.ExecuteQueryDataTable(query, ("@ClientId", clientId));

                dgvMyProjects.Columns.Clear();
                dgvMyProjects.Columns.Add("project_id", "Project ID");
                dgvMyProjects.Columns.Add("title", "Title");
                dgvMyProjects.Columns.Add("description", "Description");
                dgvMyProjects.Columns.Add("budget", "Budget");
                dgvMyProjects.Columns.Add("deadline", "Deadline");
                dgvMyProjects.Columns.Add("status", "Status");
                dgvMyProjects.Columns.Add("assigned_freelancer_id", "Assigned Freelancer ID");
                dgvMyProjects.Columns.Add("latest_bid_freelancer_id", "Latest Bid Freelancer ID");

                foreach (DataRow row in dt.Rows)
                {
                    dgvMyProjects.Rows.Add(
                        row["project_id"],
                        row["title"],
                        row["description"],
                        row["budget"],
                        row["deadline"],
                        row["status"],
                        row["assigned_freelancer_id"] == DBNull.Value ? "None" : row["assigned_freelancer_id"].ToString(),
                        row["latest_bid_freelancer_id"] == DBNull.Value ? "None" : row["latest_bid_freelancer_id"].ToString()
                    );
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No projects found for this client.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading projects: {ex.Message}");
            }
            finally
            {
                dbObj.cnClose();
            }
        }
        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false; // Hide the dashboard
                frmPostProjectForm postProjectForm = new frmPostProjectForm(clientId, notifier);
                postProjectForm.FormClosed += (s, args) =>
                {
                    if (!isFormClosing && this.Visible)
                    {
                        LoadClientProjects();
                    }
                };
                postProjectForm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening post project form: {ex.Message}");
                if (!isFormClosing) this.Visible = true; // Ensure the dashboard is visible if an error occurs
            }
        }

        private void btnReviewBids_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMyProjects.SelectedRows.Count == 0 || dgvMyProjects.SelectedRows[0].Cells["project_id"].Value == null)
                {
                    MessageBox.Show("Please select a valid project to review bids.");
                    return;
                }

                int projectId = Convert.ToInt32(dgvMyProjects.SelectedRows[0].Cells["project_id"].Value);
                this.Hide(); // Hide instead of setting Visible to false

                ReviewBidsForm reviewForm = new ReviewBidsForm(clientId, projectId);
                reviewForm.FormClosed += (s, args) =>
                {
                    if (!isFormClosing && this.Visible)
                    {
                        LoadClientProjects();
                    }
                };
                reviewForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening review bids form: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}");
                this.Show(); // Ensure dashboard remains visible
            }
        }

        private void btnLeaveReview_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMyProjects.SelectedRows.Count > 0)
                {
                    string status = dgvMyProjects.SelectedRows[0].Cells["status"].Value.ToString();
                    if (status != "completed")
                    {
                        MessageBox.Show("Please select a completed project to leave a review.");
                        return;
                    }
                    int projectId = Convert.ToInt32(dgvMyProjects.SelectedRows[0].Cells["project_id"].Value);
                    object freelancerIdObj = dgvMyProjects.SelectedRows[0].Cells["freelancer_id"].Value;
                    if (freelancerIdObj == DBNull.Value || freelancerIdObj == null)
                    {
                        MessageBox.Show("No freelancer assigned to this project.");
                        return;
                    }
                    int freelancerId = Convert.ToInt32(freelancerIdObj);

                    this.Visible = false; // Hide the dashboard
                    LeaveReviewForm reviewForm = new LeaveReviewForm(projectId, freelancerId, clientId);
                    reviewForm.FormClosed += (s, args) =>
                    {
                        if (!isFormClosing && this.Visible)
                        {
                            LoadClientProjects();
                        }
                    };
                    reviewForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a completed project to leave a review.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening leave review form: {ex.Message}");
                if (!isFormClosing) this.Visible = true; // Ensure the dashboard is visible if an error occurs
            }
        }


        private void llbLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                NavigateToLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during logout: {ex.Message}");
            }
        }

        private void pcbClientProfile_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false; // Hide the dashboard
                ClientProfileForm clientProfile = new ClientProfileForm(clientId);
                clientProfile.FormClosed += (s, args) =>
                {
                    if (!isFormClosing)
                    {
                        this.Visible = true; // Show the dashboard again after the form closes
                    }
                };
                clientProfile.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening client profile form: {ex.Message}");
                if (!isFormClosing) this.Visible = true; // Ensure the dashboard is visible if an error occurs
            }
        }

        
        private void btnViewFreelancerProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMyProjects.SelectedRows.Count > 0)
                {
                    object freelancerIdObj = dgvMyProjects.SelectedRows[0].Cells["latest_bid_freelancer_id"].Value;
                    Console.WriteLine($"Raw Latest Bid Freelancer ID Object: {freelancerIdObj?.ToString() ?? "null"}");
                    if (freelancerIdObj == DBNull.Value || freelancerIdObj == null || freelancerIdObj.ToString() == "None")
                    {
                        MessageBox.Show("No latest bid freelancer assigned to this project yet.");
                        return;
                    }
                    int freelancerId = Convert.ToInt32(freelancerIdObj);
                    Console.WriteLine($"Converted Latest Bid Freelancer ID: {freelancerId}");
                    this.Visible = false;
                    FreelancerProfileForm profileForm = new FreelancerProfileForm(freelancerId, false);
                    profileForm.FormClosed += (s, args) =>
                    {
                        if (!isFormClosing)
                        {
                            this.Visible = true;
                            LoadClientProjects();
                        }
                    };
                    profileForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a project to view the freelancer's profile.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening freelancer profile form: {ex.Message}\nStack Trace: {ex.StackTrace}");
                if (!isFormClosing) this.Visible = true;
            }
        }
        private void frmClientDashboard_Load(object sender, EventArgs e)
        {
            if (!isFormClosing) LoadClientProjects();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            isFormClosing = true; // Set the flag to prevent further operations
        }


    }
}