namespace FreelancePlatform
{
    partial class frmFreelancerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFreelancerDashboard));
            this.llbLogOut = new System.Windows.Forms.LinkLabel();
            this.tpcReview = new System.Windows.Forms.TabPage();
            this.lstReviews = new System.Windows.Forms.ListBox();
            this.tpcCompletedProjects = new System.Windows.Forms.TabPage();
            this.dgvCompletedProjects = new System.Windows.Forms.DataGridView();
            this.tpcOngoingProjects = new System.Windows.Forms.TabPage();
            this.dgvOngoingProjects = new System.Windows.Forms.DataGridView();
            this.tpcAvailableProjects = new System.Windows.Forms.TabPage();
            this.btnStartBid = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchSkills = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAvailableProjects = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.pcbFreelancerProfile = new System.Windows.Forms.PictureBox();
            this.tpcReview.SuspendLayout();
            this.tpcCompletedProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedProjects)).BeginInit();
            this.tpcOngoingProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOngoingProjects)).BeginInit();
            this.tpcAvailableProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableProjects)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFreelancerProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // llbLogOut
            // 
            this.llbLogOut.ActiveLinkColor = System.Drawing.Color.Blue;
            this.llbLogOut.AutoSize = true;
            this.llbLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLogOut.Location = new System.Drawing.Point(1060, 27);
            this.llbLogOut.Name = "llbLogOut";
            this.llbLogOut.Size = new System.Drawing.Size(69, 20);
            this.llbLogOut.TabIndex = 1;
            this.llbLogOut.TabStop = true;
            this.llbLogOut.Text = "Log Out";
            this.llbLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLogOut_LinkClicked);
            // 
            // tpcReview
            // 
            this.tpcReview.Controls.Add(this.lstReviews);
            this.tpcReview.Location = new System.Drawing.Point(4, 25);
            this.tpcReview.Name = "tpcReview";
            this.tpcReview.Size = new System.Drawing.Size(1119, 606);
            this.tpcReview.TabIndex = 4;
            this.tpcReview.Text = "Review";
            this.tpcReview.UseVisualStyleBackColor = true;
            // 
            // lstReviews
            // 
            this.lstReviews.FormattingEnabled = true;
            this.lstReviews.ItemHeight = 16;
            this.lstReviews.Location = new System.Drawing.Point(-4, 3);
            this.lstReviews.Name = "lstReviews";
            this.lstReviews.Size = new System.Drawing.Size(1120, 596);
            this.lstReviews.TabIndex = 1;
            // 
            // tpcCompletedProjects
            // 
            this.tpcCompletedProjects.Controls.Add(this.dgvCompletedProjects);
            this.tpcCompletedProjects.Location = new System.Drawing.Point(4, 25);
            this.tpcCompletedProjects.Name = "tpcCompletedProjects";
            this.tpcCompletedProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tpcCompletedProjects.Size = new System.Drawing.Size(1119, 606);
            this.tpcCompletedProjects.TabIndex = 2;
            this.tpcCompletedProjects.Text = "Completed Projects";
            this.tpcCompletedProjects.UseVisualStyleBackColor = true;
            // 
            // dgvCompletedProjects
            // 
            this.dgvCompletedProjects.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCompletedProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompletedProjects.Location = new System.Drawing.Point(3, 6);
            this.dgvCompletedProjects.Name = "dgvCompletedProjects";
            this.dgvCompletedProjects.RowHeadersWidth = 51;
            this.dgvCompletedProjects.RowTemplate.Height = 24;
            this.dgvCompletedProjects.Size = new System.Drawing.Size(1110, 594);
            this.dgvCompletedProjects.TabIndex = 0;
            // 
            // tpcOngoingProjects
            // 
            this.tpcOngoingProjects.Controls.Add(this.dgvOngoingProjects);
            this.tpcOngoingProjects.Location = new System.Drawing.Point(4, 25);
            this.tpcOngoingProjects.Name = "tpcOngoingProjects";
            this.tpcOngoingProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tpcOngoingProjects.Size = new System.Drawing.Size(1119, 606);
            this.tpcOngoingProjects.TabIndex = 1;
            this.tpcOngoingProjects.Text = "Ongoing Projects";
            this.tpcOngoingProjects.UseVisualStyleBackColor = true;
            // 
            // dgvOngoingProjects
            // 
            this.dgvOngoingProjects.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOngoingProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOngoingProjects.Location = new System.Drawing.Point(7, 45);
            this.dgvOngoingProjects.Name = "dgvOngoingProjects";
            this.dgvOngoingProjects.RowHeadersWidth = 51;
            this.dgvOngoingProjects.RowTemplate.Height = 24;
            this.dgvOngoingProjects.Size = new System.Drawing.Size(1106, 555);
            this.dgvOngoingProjects.TabIndex = 0;
            // 
            // tpcAvailableProjects
            // 
            this.tpcAvailableProjects.Controls.Add(this.btnStartBid);
            this.tpcAvailableProjects.Controls.Add(this.txtSearchSkills);
            this.tpcAvailableProjects.Controls.Add(this.btnSearch);
            this.tpcAvailableProjects.Controls.Add(this.dgvAvailableProjects);
            this.tpcAvailableProjects.Location = new System.Drawing.Point(4, 25);
            this.tpcAvailableProjects.Name = "tpcAvailableProjects";
            this.tpcAvailableProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tpcAvailableProjects.Size = new System.Drawing.Size(1119, 606);
            this.tpcAvailableProjects.TabIndex = 0;
            this.tpcAvailableProjects.Text = "Available Projects";
            this.tpcAvailableProjects.UseVisualStyleBackColor = true;
            // 
            // btnStartBid
            // 
            this.btnStartBid.Animated = true;
            this.btnStartBid.AutoRoundedCorners = true;
            this.btnStartBid.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartBid.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartBid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartBid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartBid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStartBid.ForeColor = System.Drawing.Color.White;
            this.btnStartBid.Location = new System.Drawing.Point(484, 546);
            this.btnStartBid.Name = "btnStartBid";
            this.btnStartBid.Size = new System.Drawing.Size(134, 54);
            this.btnStartBid.TabIndex = 4;
            this.btnStartBid.Text = "Start to Bid";
            this.btnStartBid.Click += new System.EventHandler(this.btnStartBid_Click);
            // 
            // txtSearchSkills
            // 
            this.txtSearchSkills.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchSkills.DefaultText = "";
            this.txtSearchSkills.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchSkills.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchSkills.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchSkills.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchSkills.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchSkills.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchSkills.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchSkills.Location = new System.Drawing.Point(776, 25);
            this.txtSearchSkills.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchSkills.Name = "txtSearchSkills";
            this.txtSearchSkills.PlaceholderText = "";
            this.txtSearchSkills.SelectedText = "";
            this.txtSearchSkills.Size = new System.Drawing.Size(229, 37);
            this.txtSearchSkills.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1011, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvAvailableProjects
            // 
            this.dgvAvailableProjects.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAvailableProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableProjects.Location = new System.Drawing.Point(6, 69);
            this.dgvAvailableProjects.Name = "dgvAvailableProjects";
            this.dgvAvailableProjects.RowHeadersWidth = 51;
            this.dgvAvailableProjects.RowTemplate.Height = 24;
            this.dgvAvailableProjects.Size = new System.Drawing.Size(1107, 471);
            this.dgvAvailableProjects.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpcAvailableProjects);
            this.tabControl1.Controls.Add(this.tpcOngoingProjects);
            this.tabControl1.Controls.Add(this.tpcCompletedProjects);
            this.tabControl1.Controls.Add(this.tpcReview);
            this.tabControl1.Location = new System.Drawing.Point(12, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1127, 635);
            this.tabControl1.TabIndex = 0;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // pcbFreelancerProfile
            // 
            this.pcbFreelancerProfile.Image = global::FreelancePlatform.Properties.Resources.profileLogo;
            this.pcbFreelancerProfile.Location = new System.Drawing.Point(1004, 12);
            this.pcbFreelancerProfile.Name = "pcbFreelancerProfile";
            this.pcbFreelancerProfile.Size = new System.Drawing.Size(37, 44);
            this.pcbFreelancerProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFreelancerProfile.TabIndex = 21;
            this.pcbFreelancerProfile.TabStop = false;
            this.pcbFreelancerProfile.Click += new System.EventHandler(this.pcbFreelancerProfile_Click);
            // 
            // frmFreelancerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1151, 719);
            this.Controls.Add(this.pcbFreelancerProfile);
            this.Controls.Add(this.llbLogOut);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFreelancerDashboard";
            this.Text = "FreelancerDashboard";
            this.tpcReview.ResumeLayout(false);
            this.tpcCompletedProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedProjects)).EndInit();
            this.tpcOngoingProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOngoingProjects)).EndInit();
            this.tpcAvailableProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableProjects)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFreelancerProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel llbLogOut;
        private System.Windows.Forms.PictureBox pcbFreelancerProfile;
        private System.Windows.Forms.TabPage tpcReview;
        private System.Windows.Forms.ListBox lstReviews;
        private System.Windows.Forms.TabPage tpcCompletedProjects;
        private System.Windows.Forms.DataGridView dgvCompletedProjects;
        private System.Windows.Forms.TabPage tpcOngoingProjects;
        private System.Windows.Forms.DataGridView dgvOngoingProjects;
        private System.Windows.Forms.TabPage tpcAvailableProjects;
        private System.Windows.Forms.DataGridView dgvAvailableProjects;
        private System.Windows.Forms.TabControl tabControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchSkills;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnStartBid;
    }
}