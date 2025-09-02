using FreelancePlatform.Class;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FreelancePlatform
{
    public partial class FreelancerProfileForm : Form
    {
        DataConnection dbObj = new DataConnection();
        public int freelancerId, currentUserId;
        private bool isProfileSaved = false;

        public FreelancerProfileForm(int id, bool checkFreelancer)
        {
            InitializeComponent();
            currentUserId = id;
            dbObj = new DataConnection(); // Instantiate a new DataConnection

            this.ControlBox = checkFreelancer ? false : true;

            if (!checkFreelancer)
            {
                btnSaveProfile.Visible = false;
                txtSkills.ReadOnly = true;
                txtExpertise.ReadOnly = true;
                txtPortfolio.ReadOnly = true;
                txtPastWork.ReadOnly = true;
            }

            dbObj.cnOpen();

            string userQuery = "SELECT user_id FROM user WHERE user_id = @UserId";
            MySqlDataReader userDr = dbObj.ExecuteReader(userQuery, ("@UserId", id));
            if (!userDr.Read())
            {
                userDr.Close();
                MessageBox.Show("Invalid user ID. User does not exist.");
                dbObj.cnClose();
                return;
            }
            userDr.Close();

            string query = "SELECT freelancer_id FROM freelancer WHERE user_id = @UserId";
            MySqlDataReader dr = dbObj.ExecuteReader(query, ("@UserId", id));
            if (dr.Read())
            {
                freelancerId = Convert.ToInt32(dr["freelancer_id"]);
                CreateProfile();
            }
            else
            {
                MessageBox.Show($"No freelancer profile found for user_id: {id}.");
                freelancerId = 0;
            }
            dr.Close();
            dbObj.cnClose();
        }

        public void CreateProfile()
        {
            if (freelancerId == 0)
            {
                MessageBox.Show("No valid freelancer ID to load profile.");
                txtSkills.Text = "No ID";
                txtExpertise.Text = "No ID";
                txtPortfolio.Text = "No ID";
                txtPastWork.Text = "No ID";
                return;
            }

            dbObj.cnOpen();
            Freelancer _freelancer = new Freelancer(freelancerId, null, null, null, null);
            MySqlDataReader dr = _freelancer.CreateProfile();
            Console.WriteLine($"Attempting to load profile for freelancer_id: {freelancerId}");

            if (dr != null)
            {
                if (dr.Read())
                {
                    txtSkills.Text = !dr.IsDBNull(dr.GetOrdinal("skills")) ? dr["skills"].ToString() : "No skills";
                    txtExpertise.Text = !dr.IsDBNull(dr.GetOrdinal("expertise")) ? dr["expertise"].ToString() : "No expertise";
                    txtPortfolio.Text = !dr.IsDBNull(dr.GetOrdinal("portfolio")) ? dr["portfolio"].ToString() : "No portfolio";
                    txtPastWork.Text = !dr.IsDBNull(dr.GetOrdinal("pastwork")) ? dr["pastwork"].ToString() : "No past work";
                    Console.WriteLine($"Profile loaded: Skills={txtSkills.Text}, Expertise={txtExpertise.Text}");
                }
                else
                {
                    MessageBox.Show($"No profile data found for freelancer_id: {freelancerId}. Check database.");
                    txtSkills.Text = "No data";
                    txtExpertise.Text = "No data";
                    txtPortfolio.Text = "No data";
                    txtPastWork.Text = "No data";
                }
                dr.Close();
            }
            else
            {
                MessageBox.Show($"Failed to execute query for freelancer_id: {freelancerId}");
                txtSkills.Text = "Error";
                txtExpertise.Text = "Error";
                txtPortfolio.Text = "Error";
                txtPastWork.Text = "Error";
            }
            dbObj.cnClose();
        }
        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                dbObj.cnOpen();
                Console.WriteLine($"Saving profile for user_id: {currentUserId}");

                string skills = txtSkills.Text.Trim(); // Ensure no extra spaces
                string expertise = txtExpertise.Text.Trim();
                string portfolio = txtPortfolio.Text.Trim();
                string pastWork = txtPastWork.Text.Trim();

                if (string.IsNullOrWhiteSpace(skills) || string.IsNullOrWhiteSpace(expertise) ||
                    string.IsNullOrWhiteSpace(portfolio) || string.IsNullOrWhiteSpace(pastWork))
                {
                    MessageBox.Show("All fields must be filled.");
                    dbObj.cnClose();
                    return;
                }

                string query;
                int result;

                if (freelancerId == 0)
                {
                    query = "INSERT INTO freelancer (user_id, skills, expertise, portfolio, pastwork) " +
                            "VALUES (@UserID, @Skills, @Expertise, @Portfolio, @PastWork)";
                    result = dbObj.ExecuteNonQuery(query,
                        ("@UserID", currentUserId),
                        ("@Skills", skills),
                        ("@Expertise", expertise),
                        ("@Portfolio", portfolio),
                        ("@PastWork", pastWork));

                    if (result > 0)
                    {
                        string idQuery = "SELECT freelancer_id FROM freelancer WHERE user_id = @UserID";
                        MySqlDataReader idDr = dbObj.ExecuteReader(idQuery, ("@UserID", currentUserId));
                        if (idDr.Read())
                        {
                            freelancerId = Convert.ToInt32(idDr["freelancer_id"]);
                            Console.WriteLine($"New freelancer_id: {freelancerId}");
                        }
                        idDr.Close();
                    }
                }
                else
                {
                    query = "UPDATE freelancer SET skills = @Skills, expertise = @Expertise, " +
                            "portfolio = @Portfolio, pastwork = @PastWork WHERE freelancer_id = @FreelancerId";
                    result = dbObj.ExecuteNonQuery(query,
                        ("@FreelancerId", freelancerId),
                        ("@Skills", skills),
                        ("@Expertise", expertise),
                        ("@Portfolio", portfolio),
                        ("@PastWork", pastWork));
                }

                if (result > 0)
                {
                    MessageBox.Show("Profile saved successfully!");
                    isProfileSaved = true;
                    Clear();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save profile.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving profile: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }
            finally
            {
                dbObj.cnClose();
            }
        }

        private void Clear()
        {
            txtSkills.Clear();
            txtExpertise.Clear();
            txtPortfolio.Clear();
            txtPastWork.Clear();
            txtSkills.Focus();
        }


        private void FreelancerProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isProfileSaved && e.CloseReason == CloseReason.UserClosing && this.ControlBox == false)
            {
                e.Cancel = true; // Prevent closing only if profile creation is mandatory
                MessageBox.Show("You must save your profile to proceed.");
            }
        }

    }
}