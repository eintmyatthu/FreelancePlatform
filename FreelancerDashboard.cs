using FreelancePlatform.Class;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FreelancePlatform
{
    public partial class frmFreelancerDashboard : Form
    {
        DataConnection dbObj = new DataConnection();
        ProjectNotifier notifier = new ProjectNotifier();
        Freelancer loggedInFreelancer;
        public int currentUserID = Program.uID;
        private int freelancerId;
        private string freelancerSkills;

        public frmFreelancerDashboard(int id)
        {
            InitializeComponent();
            currentUserID = id;

            try
            {
                // Check if freelancer profile exists
                dbObj.cnOpen();
                string query = "SELECT freelancer_id, skills FROM freelancer WHERE user_id = @UserId";
                MySqlDataReader dr = dbObj.ExecuteReader(query, ("@UserId", id));

                if (dr.Read())
                {
                    freelancerId = Convert.ToInt32(dr["freelancer_id"]);
                    freelancerSkills = dr["skills"].ToString();
                    MessageBox.Show("Dashboard for freelan id and skill is " + freelancerId + " and " + freelancerSkills);
                    loggedInFreelancer = new Freelancer(freelancerId, freelancerSkills);
                    notifier.RegisterObserver(loggedInFreelancer);
                    //   MessageBox.Show("freelancer Id is " + freelancerId);

                    LoadAvailableProjects();
                    LoadOngoingProjects();
                    LoadCompletedProjects();
                    LoadReviews();

                   
                    dr.Close();
                    dbObj.cnClose();

                    // Profile exists, proceed with loading the dashboard
                    LoadDashboard();
                }
                else
                {
                    dr.Close();
                    dbObj.cnClose();

                    // No profile exists, redirect to profile creation
                    MessageBox.Show("Please create your freelancer profile first.");
                    FreelancerProfileForm profileForm = new FreelancerProfileForm(id, true);
                    profileForm.FormClosed += (s, args) =>
                    {
                        // After the profile form closes, check if the profile was created
                        dbObj.cnOpen();
                        MySqlDataReader checkDr = dbObj.ExecuteReader(query, ("@UserId", id));
                        if (checkDr.Read())
                        {
                            freelancerId = Convert.ToInt32(checkDr["freelancer_id"]);
                            freelancerSkills = checkDr["skills"].ToString();
                            checkDr.Close();
                            dbObj.cnClose();
                            LoadDashboard();
                        }
                        else
                        {
                            checkDr.Close();
                            dbObj.cnClose();
                            MessageBox.Show("Profile creation is mandatory. Returning to login.");
                            NavigateToLogin();
                        }
                    };
                    profileForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing dashboard: {ex.Message}");
                NavigateToLogin();
            }
        }

        private void NavigateToLogin()
        {
            try
            {
                this.Visible = false; // Hide the dashboard
                frmLogin loginForm = new frmLogin();
                loginForm.FormClosed += (s, args) =>
                {
                    this.Close(); // Close the dashboard after the login form is closed
                };
                loginForm.Show(); // Use Show() instead of ShowDialog()
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating to login: {ex.Message}");
            }
        }

        private void LoadDashboard()
        {
            try
            {
                loggedInFreelancer = new Freelancer(freelancerId, freelancerSkills);
                notifier.RegisterObserver(loggedInFreelancer); // Register the freelancer
                LoadAvailableProjects();
                LoadOngoingProjects();
                LoadCompletedProjects();
                LoadReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}");
                NavigateToLogin();
            }
        }
        public void update(string message)
        {
            MessageBox.Show($"Notification for {freelancerId}: {message}");
        }

        private void LoadAvailableProjects(string skills = "")
        {
            try
            {
                dbObj.cnOpen();
                string query = "SELECT * FROM project WHERE status = 'Open' AND project_id NOT IN " +
                               "(SELECT project_id FROM bid WHERE status = 'Accepted')";

                if (!string.IsNullOrWhiteSpace(skills))
                {
                    query += " AND requiredSkills LIKE @Skills";
                    dgvAvailableProjects.DataSource = dbObj.ExecuteQueryDataTable(query, ("@Skills", "%" + skills + "%"));
                }
                else
                {
                    dgvAvailableProjects.DataSource = dbObj.showDataGridView(query);
                }

                dbObj.cnClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading projects: {ex.Message}");
                dbObj.cnClose();
            }
        }


        private void LoadOngoingProjects()
        {
            dbObj.cnOpen();
            string query = "SELECT * FROM project WHERE status = 'ongoing' AND freelancer_id = @FreelancerId";
            dgvOngoingProjects.DataSource = dbObj.ExecuteQueryDataTable(query, ("@FreelancerId", freelancerId));
            dbObj.cnClose();
        }

        private void LoadCompletedProjects()
        {
            dbObj.cnOpen();
            string query = "SELECT * FROM project WHERE status = 'completed' AND freelancer_id = @FreelancerId";
            dgvCompletedProjects.DataSource = dbObj.ExecuteQueryDataTable(query, ("@FreelancerId", freelancerId));
            dbObj.cnClose();
        }

        private void btnStartBid_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAvailableProjects.SelectedRows.Count > 0)
                {
                    int projectId = Convert.ToInt32(dgvAvailableProjects.SelectedRows[0].Cells["project_id"].Value);
                    this.Visible = false; // Hide the dashboard
                    BidForm bidForm = new BidForm(projectId, freelancerId);
                    bidForm.FormClosed += (s, args) =>
                    {
                        this.Visible = true; // Show the dashboard again after the bid form closes
                    };
                    bidForm.ShowDialog();
                    LoadAvailableProjects();
                }
                else
                {
                    MessageBox.Show("Please select a project to bid on.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening bid form: {ex.Message}");
                this.Visible = true; // Ensure the dashboard is visible if an error occurs
            }
        }

        private void LoadReviews()
        {
            dbObj.cnOpen();
            string query = "SELECT * FROM review WHERE freelancer_id = @FreelancerId ORDER BY created_at DESC";
            MySqlDataReader dr = dbObj.ExecuteReader(query, ("@FreelancerId", freelancerId));
            lstReviews.Items.Clear();

            while (dr.Read())
            {
                int projectID = Convert.ToInt32(dr["project_id"]);
                int rating = Convert.ToInt32(dr["rating"]);
                string reviewText = dr["review_text"].ToString();
                string createDate = dr["created_at"].ToString();
                string stars = new string('*', rating);

                lstReviews.Items.Add($"Review for Project ID: {projectID}");
                lstReviews.Items.Add($"Rating: {stars}");
                lstReviews.Items.Add($"Review Text: {reviewText}");
                lstReviews.Items.Add($"Created: {createDate}");
            }
            dr.Close();
            dbObj.cnClose();
        }

        private void llbLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                notifier.RemoveObserver(loggedInFreelancer);
                NavigateToLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during logout: {ex.Message}");
                NavigateToLogin();
            }
        }

        private void pcbFreelancerProfile_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false; // Hide the dashboard
                FreelancerProfileForm freelancerProfile = new FreelancerProfileForm(currentUserID, true);
                freelancerProfile.FormClosed += (s, args) =>
                {
                    this.Visible = true; // Show the dashboard again after the profile form closes
                };
                freelancerProfile.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening profile form: {ex.Message}");
                this.Visible = true; // Ensure the dashboard is visible if an error occurs
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchSkills = txtSearchSkills.Text.Trim();
            LoadAvailableProjects(searchSkills);
        }


    }
}