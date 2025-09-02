namespace FreelancePlatform
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.chkShowHidePwd = new System.Windows.Forms.CheckBox();
            this.chkShowHideConfirmPwd = new System.Windows.Forms.CheckBox();
            this.llbLogin = new System.Windows.Forms.LinkLabel();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbSelectType = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdoClient = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoFreelancer = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.lblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblConfirmPwd = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSelectType.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkShowHidePwd
            // 
            this.chkShowHidePwd.AutoSize = true;
            this.chkShowHidePwd.Location = new System.Drawing.Point(610, 228);
            this.chkShowHidePwd.Name = "chkShowHidePwd";
            this.chkShowHidePwd.Size = new System.Drawing.Size(62, 20);
            this.chkShowHidePwd.TabIndex = 4;
            this.chkShowHidePwd.Text = "Show";
            this.chkShowHidePwd.UseVisualStyleBackColor = true;
            this.chkShowHidePwd.CheckedChanged += new System.EventHandler(this.chkShowHidePwd_CheckedChanged);
            // 
            // chkShowHideConfirmPwd
            // 
            this.chkShowHideConfirmPwd.AutoSize = true;
            this.chkShowHideConfirmPwd.Location = new System.Drawing.Point(610, 324);
            this.chkShowHideConfirmPwd.Name = "chkShowHideConfirmPwd";
            this.chkShowHideConfirmPwd.Size = new System.Drawing.Size(62, 20);
            this.chkShowHideConfirmPwd.TabIndex = 7;
            this.chkShowHideConfirmPwd.Text = "Show";
            this.chkShowHideConfirmPwd.UseVisualStyleBackColor = true;
            this.chkShowHideConfirmPwd.CheckedChanged += new System.EventHandler(this.chkShowHideConfirmPwd_CheckedChanged);
            // 
            // llbLogin
            // 
            this.llbLogin.AutoSize = true;
            this.llbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLogin.Location = new System.Drawing.Point(287, 584);
            this.llbLogin.Name = "llbLogin";
            this.llbLogin.Size = new System.Drawing.Size(247, 20);
            this.llbLogin.TabIndex = 10;
            this.llbLogin.TabStop = true;
            this.llbLogin.Text = "Already have an account? Login";
            this.llbLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLogin_LinkClicked);
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(316, 114);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(229, 48);
            this.txtUsername.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(316, 212);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(229, 48);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPwd.DefaultText = "";
            this.txtConfirmPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPwd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPwd.Location = new System.Drawing.Point(316, 308);
            this.txtConfirmPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PlaceholderText = "";
            this.txtConfirmPwd.SelectedText = "";
            this.txtConfirmPwd.Size = new System.Drawing.Size(229, 48);
            this.txtConfirmPwd.TabIndex = 13;
            this.txtConfirmPwd.UseSystemPasswordChar = true;
            // 
            // gbSelectType
            // 
            this.gbSelectType.Controls.Add(this.rdoClient);
            this.gbSelectType.Controls.Add(this.rdoFreelancer);
            this.gbSelectType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbSelectType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbSelectType.Location = new System.Drawing.Point(268, 399);
            this.gbSelectType.Name = "gbSelectType";
            this.gbSelectType.Size = new System.Drawing.Size(325, 108);
            this.gbSelectType.TabIndex = 14;
            this.gbSelectType.Text = "Select User Type";
            // 
            // rdoClient
            // 
            this.rdoClient.AutoSize = true;
            this.rdoClient.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoClient.CheckedState.BorderThickness = 0;
            this.rdoClient.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoClient.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoClient.CheckedState.InnerOffset = -4;
            this.rdoClient.Location = new System.Drawing.Point(183, 56);
            this.rdoClient.Name = "rdoClient";
            this.rdoClient.Size = new System.Drawing.Size(68, 24);
            this.rdoClient.TabIndex = 1;
            this.rdoClient.Text = "Client\r\n";
            this.rdoClient.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoClient.UncheckedState.BorderThickness = 2;
            this.rdoClient.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoClient.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdoFreelancer
            // 
            this.rdoFreelancer.AutoSize = true;
            this.rdoFreelancer.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoFreelancer.CheckedState.BorderThickness = 0;
            this.rdoFreelancer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoFreelancer.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoFreelancer.CheckedState.InnerOffset = -4;
            this.rdoFreelancer.Location = new System.Drawing.Point(23, 56);
            this.rdoFreelancer.Name = "rdoFreelancer";
            this.rdoFreelancer.Size = new System.Drawing.Size(98, 24);
            this.rdoFreelancer.TabIndex = 0;
            this.rdoFreelancer.Text = "Freelancer";
            this.rdoFreelancer.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoFreelancer.UncheckedState.BorderThickness = 2;
            this.rdoFreelancer.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoFreelancer.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // btnRegister
            // 
            this.btnRegister.Animated = true;
            this.btnRegister.AutoRoundedCorners = true;
            this.btnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(339, 525);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(180, 45);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = false;
            this.lblUsername.AutoSizeHeightOnly = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblUsername.Location = new System.Drawing.Point(115, 124);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(167, 26);
            this.lblUsername.TabIndex = 16;
            this.lblUsername.Text = "User Name:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = false;
            this.lblPassword.AutoSizeHeightOnly = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPassword.Location = new System.Drawing.Point(122, 228);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(160, 26);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Password:";
            // 
            // lblConfirmPwd
            // 
            this.lblConfirmPwd.AutoSize = false;
            this.lblConfirmPwd.AutoSizeHeightOnly = true;
            this.lblConfirmPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPwd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblConfirmPwd.Location = new System.Drawing.Point(39, 324);
            this.lblConfirmPwd.Name = "lblConfirmPwd";
            this.lblConfirmPwd.Size = new System.Drawing.Size(229, 26);
            this.lblConfirmPwd.TabIndex = 18;
            this.lblConfirmPwd.Text = "Confirm Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(283, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 45);
            this.label1.TabIndex = 20;
            this.label1.Text = "Create your account";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(984, 618);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConfirmPwd);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.gbSelectType);
            this.Controls.Add(this.txtConfirmPwd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.llbLogin);
            this.Controls.Add(this.chkShowHideConfirmPwd);
            this.Controls.Add(this.chkShowHidePwd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegister";
            this.Text = "Registeration";
            this.gbSelectType.ResumeLayout(false);
            this.gbSelectType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkShowHidePwd;
        private System.Windows.Forms.CheckBox chkShowHideConfirmPwd;
        private System.Windows.Forms.LinkLabel llbLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPwd;
        private Guna.UI2.WinForms.Guna2GroupBox gbSelectType;
        private Guna.UI2.WinForms.Guna2RadioButton rdoClient;
        private Guna.UI2.WinForms.Guna2RadioButton rdoFreelancer;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsername;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblConfirmPwd;
        private System.Windows.Forms.Label label1;
    }
}

