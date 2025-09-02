using FreelancePlatform.Class;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FreelancePlatform
{
    public partial class ClientProfileForm : Form
    {
        DataConnection dbObj = new DataConnection();
        public int currentUserID;
        public int clientId;
        private bool isProfileSaved = false;

        public ClientProfileForm(int clientID)
        {
            InitializeComponent();
            clientId = clientID;

            // Disable the close button to prevent bypassing profile creation
            this.ControlBox = false;

            if (clientId != 0)
            {
                try
                {
                    dbObj.cnOpen();
                    string query = "SELECT user_id FROM client WHERE client_id = @ClientId";
                    MySqlDataReader dr = dbObj.ExecuteReader(query, ("@ClientId", clientId));

                    if (dr.Read())
                    {
                        currentUserID = Convert.ToInt32(dr["user_id"]);
                        CreateProfile();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Client not found.");
                        NavigateToLogin();
                        return;
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing client profile form: {ex.Message}");
                    NavigateToLogin();
                }
                finally
                {
                    dbObj.cnClose();
                }
            }
        }

        public void CreateProfile()
        {
            try
            {
                dbObj.cnOpen();
                Client _client = new Client(clientId, null, null);
                MySqlDataReader dr = _client.CreateProfile();

                if (dr.Read())
                {
                    txtCompany.Text = dr["company"].ToString();
                    txtContactNo.Text = dr["contactNo"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading client profile: {ex.Message}");
                NavigateToLogin();
            }
            finally
            {
                dbObj.cnClose();
            }
        }


        private void NavigateToLogin()
        {
            try
            {
                this.DialogResult = DialogResult.Cancel; // Indicate cancellation
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating to login: {ex.Message}");
            }
        }

        private void Clear()
        {
            txtCompany.Clear();
            txtContactNo.Clear();
            txtCompany.Focus();
        }

        private void ClientProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isProfileSaved && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Prevent closing unless the profile is saved
                MessageBox.Show("You must save your profile to proceed.");
            }
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                dbObj.cnOpen();

                string company = txtCompany.Text;
                string contactNo = txtContactNo.Text;

                if (string.IsNullOrWhiteSpace(company) || string.IsNullOrWhiteSpace(contactNo))
                {
                    MessageBox.Show("All fields must be filled.");
                    return;
                }

                // Validate user_id exists in the user table
                string userQuery = "SELECT user_id FROM user WHERE user_id = @UserId";
                MySqlDataReader userDr = dbObj.ExecuteReader(userQuery, ("@UserId", currentUserID));
                if (!userDr.Read())
                {
                    userDr.Close();
                    MessageBox.Show("Invalid user ID. User does not exist.");
                    NavigateToLogin();
                    return;
                }
                userDr.Close();

                string query;
                int result;

                if (clientId == 0) // New client
                {
                    query = "INSERT INTO client (user_id, company, contactNo) " +
                            "VALUES (@UserID, @Company, @ContactNo)";
                    result = dbObj.ExecuteNonQuery(query,
                        ("@UserID", currentUserID),
                        ("@Company", company),
                        ("@ContactNo", contactNo));

                    if (result > 0)
                    {
                        string idQuery = "SELECT client_id FROM client WHERE user_id = @UserID";
                        MySqlDataReader idDr = dbObj.ExecuteReader(idQuery, ("@UserID", currentUserID));
                        if (idDr.Read())
                        {
                            clientId = Convert.ToInt32(idDr["client_id"]);
                        }
                        idDr.Close();
                    }
                }
                else // Existing client
                {
                    query = "UPDATE client SET company = @Company, contactNo = @ContactNo WHERE client_id = @ClientId";
                    result = dbObj.ExecuteNonQuery(query,
                        ("@ClientId", clientId),
                        ("@Company", company),
                        ("@ContactNo", contactNo));
                }

                if (result > 0)
                {
                    MessageBox.Show("Client Profile saved successfully!");
                    isProfileSaved = true;
                    Clear();
                    this.DialogResult = DialogResult.OK; // Indicate successful save
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save client profile.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving client profile: {ex.Message}");
            }
            finally
            {
                dbObj.cnClose();
            }
        }
    }
}