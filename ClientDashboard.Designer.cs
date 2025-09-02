namespace FreelancePlatform
{
    partial class frmClientDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientDashboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpcClientProject = new System.Windows.Forms.TabPage();
            this.btnReviewBids = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewFreelancerProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnLeaveReview = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateProject = new Guna.UI2.WinForms.Guna2Button();
            this.dgvMyProjects = new System.Windows.Forms.DataGridView();
            this.llbLogOut = new System.Windows.Forms.LinkLabel();
            this.pcbClientProfile = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tpcClientProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClientProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpcClientProject);
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1159, 586);
            this.tabControl1.TabIndex = 17;
            // 
            // tpcClientProject
            // 
            this.tpcClientProject.Controls.Add(this.btnReviewBids);
            this.tpcClientProject.Controls.Add(this.btnViewFreelancerProfile);
            this.tpcClientProject.Controls.Add(this.btnLeaveReview);
            this.tpcClientProject.Controls.Add(this.btnCreateProject);
            this.tpcClientProject.Controls.Add(this.dgvMyProjects);
            this.tpcClientProject.Location = new System.Drawing.Point(4, 25);
            this.tpcClientProject.Name = "tpcClientProject";
            this.tpcClientProject.Padding = new System.Windows.Forms.Padding(3);
            this.tpcClientProject.Size = new System.Drawing.Size(1151, 557);
            this.tpcClientProject.TabIndex = 0;
            this.tpcClientProject.Text = "Projects";
            this.tpcClientProject.UseVisualStyleBackColor = true;
            // 
            // btnReviewBids
            // 
            this.btnReviewBids.Animated = true;
            this.btnReviewBids.AutoRoundedCorners = true;
            this.btnReviewBids.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReviewBids.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReviewBids.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReviewBids.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReviewBids.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReviewBids.ForeColor = System.Drawing.Color.White;
            this.btnReviewBids.Location = new System.Drawing.Point(348, 509);
            this.btnReviewBids.Name = "btnReviewBids";
            this.btnReviewBids.Size = new System.Drawing.Size(144, 42);
            this.btnReviewBids.TabIndex = 19;
            this.btnReviewBids.Text = "Review Bids";
           this.btnReviewBids.Click += new System.EventHandler(this.btnReviewBids_Click);
            // 
            // btnViewFreelancerProfile
            // 
            this.btnViewFreelancerProfile.Animated = true;
            this.btnViewFreelancerProfile.AutoRoundedCorners = true;
            this.btnViewFreelancerProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewFreelancerProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewFreelancerProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewFreelancerProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewFreelancerProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewFreelancerProfile.ForeColor = System.Drawing.Color.White;
            this.btnViewFreelancerProfile.Location = new System.Drawing.Point(848, 509);
            this.btnViewFreelancerProfile.Name = "btnViewFreelancerProfile";
            this.btnViewFreelancerProfile.Size = new System.Drawing.Size(188, 42);
            this.btnViewFreelancerProfile.TabIndex = 18;
            this.btnViewFreelancerProfile.Text = "View Freelancer Profile";
            this.btnViewFreelancerProfile.Click += new System.EventHandler(this.btnViewFreelancerProfile_Click);
            // 
            // btnLeaveReview
            // 
            this.btnLeaveReview.Animated = true;
            this.btnLeaveReview.AutoRoundedCorners = true;
            this.btnLeaveReview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLeaveReview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLeaveReview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLeaveReview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLeaveReview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLeaveReview.ForeColor = System.Drawing.Color.White;
            this.btnLeaveReview.Location = new System.Drawing.Point(601, 509);
            this.btnLeaveReview.Name = "btnLeaveReview";
            this.btnLeaveReview.Size = new System.Drawing.Size(144, 42);
            this.btnLeaveReview.TabIndex = 17;
            this.btnLeaveReview.Text = "Leave Review";
            this.btnLeaveReview.Click += new System.EventHandler(this.btnLeaveReview_Click);
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Animated = true;
            this.btnCreateProject.AutoRoundedCorners = true;
            this.btnCreateProject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateProject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateProject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateProject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateProject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreateProject.ForeColor = System.Drawing.Color.White;
            this.btnCreateProject.Location = new System.Drawing.Point(82, 509);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(144, 42);
            this.btnCreateProject.TabIndex = 16;
            this.btnCreateProject.Text = "Create Project";
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // dgvMyProjects
            // 
            this.dgvMyProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMyProjects.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMyProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyProjects.Location = new System.Drawing.Point(-4, 0);
            this.dgvMyProjects.Name = "dgvMyProjects";
            this.dgvMyProjects.RowHeadersWidth = 51;
            this.dgvMyProjects.RowTemplate.Height = 24;
            this.dgvMyProjects.Size = new System.Drawing.Size(1155, 503);
            this.dgvMyProjects.TabIndex = 0;
            // 
            // llbLogOut
            // 
            this.llbLogOut.ActiveLinkColor = System.Drawing.Color.Blue;
            this.llbLogOut.AutoSize = true;
            this.llbLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLogOut.Location = new System.Drawing.Point(1094, 26);
            this.llbLogOut.Name = "llbLogOut";
            this.llbLogOut.Size = new System.Drawing.Size(69, 20);
            this.llbLogOut.TabIndex = 18;
            this.llbLogOut.TabStop = true;
            this.llbLogOut.Text = "Log Out";
            this.llbLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLogOut_LinkClicked);
            // 
            // pcbClientProfile
            // 
            this.pcbClientProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbClientProfile.Image = global::FreelancePlatform.Properties.Resources.profileLogo;
            this.pcbClientProfile.Location = new System.Drawing.Point(1049, 12);
            this.pcbClientProfile.Name = "pcbClientProfile";
            this.pcbClientProfile.Size = new System.Drawing.Size(37, 44);
            this.pcbClientProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbClientProfile.TabIndex = 20;
            this.pcbClientProfile.TabStop = false;
            this.pcbClientProfile.Click += new System.EventHandler(this.pcbClientProfile_Click);
            // 
            // frmClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1175, 637);
            this.Controls.Add(this.pcbClientProfile);
            this.Controls.Add(this.llbLogOut);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientDashboard";
            this.Text = "ClientDashboard";
            this.Load += new System.EventHandler(this.frmClientDashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpcClientProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClientProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpcClientProject;
        private System.Windows.Forms.DataGridView dgvMyProjects;
        private System.Windows.Forms.LinkLabel llbLogOut;
        private System.Windows.Forms.PictureBox pcbClientProfile;
        private Guna.UI2.WinForms.Guna2Button btnCreateProject;
        private Guna.UI2.WinForms.Guna2Button btnReviewBids;
        private Guna.UI2.WinForms.Guna2Button btnViewFreelancerProfile;
        private Guna.UI2.WinForms.Guna2Button btnLeaveReview;
    }
}