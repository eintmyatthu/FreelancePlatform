using FreelancePlatform.Class;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FreelancePlatform
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }


        private void chkShowHidePwd_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowHidePwd.Checked;
        }

        private void chkShowHideConfirmPwd_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmPwd.UseSystemPasswordChar = !chkShowHideConfirmPwd.Checked;
        }

        private void llbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string uname = txtUsername.Text;
            string pwd = txtPassword.Text;
            string confirmPwd = txtConfirmPwd.Text;
            string uType = rdoFreelancer.Checked ? "Freelancer" : rdoClient.Checked ? "Client" : null;

            if (string.IsNullOrWhiteSpace(uname) || string.IsNullOrWhiteSpace(pwd) || string.IsNullOrWhiteSpace(confirmPwd) || uType == null)
            {
                MessageBox.Show("All fields must be filled, and a user type must be selected.");
                return;
            }

            string usernamePattern = "^[a-zA-Z0-9]*$";
            string passwordPattern = "^(?=.*[a-z])(?=.*[A-Z]).{8,12}$";

            if (!Regex.IsMatch(uname, usernamePattern))
            {
                MessageBox.Show("Username must contain only letters and numbers.");
                return;
            }

            if (!Regex.IsMatch(pwd, passwordPattern))
            {
                MessageBox.Show("Password must be 8-12 characters long with at least one uppercase and one lowercase letter.");
                return;
            }

            if (pwd != confirmPwd)
            {
                MessageBox.Show("Password and Confirm Passwrod do not match.");
                return;
            }

            User user = UserFactory.RegisterUser(uname, pwd, uType);
            UserRepository userRepository = new UserRepository();
            userRepository.register(user);
        }
    }
}