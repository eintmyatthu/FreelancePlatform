namespace FreelancePlatform
{
    partial class frmFreelancerPlatform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFreelancerPlatform));
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.lblParagraph = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.img_welcome = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Animated = true;
            this.btnStart.AutoRoundedCorners = true;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(86)))), ((int)(((byte)(253)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(120, 381);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 64);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblParagraph
            // 
            this.lblParagraph.AutoSize = true;
            this.lblParagraph.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParagraph.Location = new System.Drawing.Point(19, 232);
            this.lblParagraph.Name = "lblParagraph";
            this.lblParagraph.Size = new System.Drawing.Size(398, 64);
            this.lblParagraph.TabIndex = 17;
            this.lblParagraph.Text = "Find the best freelancers to \r\ndeliver your projects";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.OldLace;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(2, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(431, 144);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Make bright \r\nideas happen\r\n";
            // 
            // img_welcome
            // 
            this.img_welcome.BackColor = System.Drawing.Color.Transparent;
            this.img_welcome.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.img_welcome.HoverState.ImageSize = new System.Drawing.Size(787, 540);
            this.img_welcome.Image = global::FreelancePlatform.Properties.Resources.freelancer_earn_scaled;
            this.img_welcome.ImageOffset = new System.Drawing.Point(0, 0);
            this.img_welcome.ImageRotate = 0F;
            this.img_welcome.ImageSize = new System.Drawing.Size(787, 540);
            this.img_welcome.IndicateFocus = true;
            this.img_welcome.Location = new System.Drawing.Point(466, -3);
            this.img_welcome.Name = "img_welcome";
            this.img_welcome.PressedState.ImageSize = new System.Drawing.Size(787, 540);
            this.img_welcome.Size = new System.Drawing.Size(787, 544);
            this.img_welcome.TabIndex = 2;
            // 
            // frmFreelancerPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 542);
            this.Controls.Add(this.lblParagraph);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.img_welcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFreelancerPlatform";
            this.Text = "Freelancer Platform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private System.Windows.Forms.Label lblParagraph;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ImageButton img_welcome;
    }
}