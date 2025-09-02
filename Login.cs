using FreelancePlatform.Class;
using System;
using System.Data;
using System.Windows.Forms;

namespace FreelancePlatform
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        UserRepository userRepository = new UserRepository();
        int failedLoginAttempt = 0;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = txtUsername.Text.Trim();
            string pwd = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(uname) || string.IsNullOrWhiteSpace(pwd))
            {
                MessageBox.Show("Please fill in both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool usernameExists = userRepository.DoesUsernameExist(uname);
            bool passwordCorrect = userRepository.IsPasswordCorrect(uname, pwd);

            if (!usernameExists)
            {
                failedLoginAttempt++;
                MessageBox.Show($"Username is incorrect.\nLogin failed {failedLoginAttempt} time(s).", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!passwordCorrect)
            {
                failedLoginAttempt++;
                MessageBox.Show($"Password is incorrect.\nLogin failed {failedLoginAttempt} time(s).", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Successful login
                DataTable dt = userRepository.login(uname, pwd);
                if (dt.Rows.Count > 0)
                {
                    int uID = Convert.ToInt32(dt.Rows[0]["user_id"]);
                    string userType = dt.Rows[0]["usertype"].ToString();
                    this.Hide();

                    if (userType == "Freelancer")
                    {
                        frmFreelancerDashboard freelancerDashboard = new frmFreelancerDashboard(uID);
                        freelancerDashboard.ShowDialog();
                    }
                    else
                    {
                        frmClientDashboard clientDashboard = new frmClientDashboard(uID);
                        clientDashboard.ShowDialog();
                    }
                }
            }

            // Lock after 3 failed attempts
            if (failedLoginAttempt == 3)
            {
                timer1.Interval = 3000;
                timer1.Start();
                txtUsername.ReadOnly = true;
                txtPassword.ReadOnly = true;
                btnLogin.Enabled = false;
                lblLockMsg.Text = "Too many failed attempts! Please wait 3 seconds.";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            txtUsername.ReadOnly = false;
            txtPassword.ReadOnly = false;
            btnLogin.Enabled = true;
            lblLockMsg.Text = "";
            failedLoginAttempt = 0;
        }

        private void llbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRegister registerForm = new frmRegister();
            registerForm.ShowDialog();
        }

        private void chkShowHidePwd_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowHidePwd.Checked;
        }

       
    }
}