namespace FreelancePlatform
{
    partial class BidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BidForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBidAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEstimatedDays = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSubmitBid = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(282, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bid Amount (€): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(282, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estimated Days:";
            // 
            // txtBidAmount
            // 
            this.txtBidAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBidAmount.DefaultText = "";
            this.txtBidAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBidAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBidAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBidAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBidAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBidAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBidAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBidAmount.Location = new System.Drawing.Point(285, 188);
            this.txtBidAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBidAmount.Name = "txtBidAmount";
            this.txtBidAmount.PlaceholderText = "";
            this.txtBidAmount.SelectedText = "";
            this.txtBidAmount.Size = new System.Drawing.Size(229, 48);
            this.txtBidAmount.TabIndex = 6;
            // 
            // txtEstimatedDays
            // 
            this.txtEstimatedDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstimatedDays.DefaultText = "";
            this.txtEstimatedDays.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEstimatedDays.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEstimatedDays.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstimatedDays.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstimatedDays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstimatedDays.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEstimatedDays.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstimatedDays.Location = new System.Drawing.Point(285, 311);
            this.txtEstimatedDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstimatedDays.Name = "txtEstimatedDays";
            this.txtEstimatedDays.PlaceholderText = "";
            this.txtEstimatedDays.SelectedText = "";
            this.txtEstimatedDays.Size = new System.Drawing.Size(229, 48);
            this.txtEstimatedDays.TabIndex = 7;
            // 
            // btnSubmitBid
            // 
            this.btnSubmitBid.Animated = true;
            this.btnSubmitBid.AutoRoundedCorners = true;
            this.btnSubmitBid.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmitBid.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmitBid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmitBid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmitBid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmitBid.ForeColor = System.Drawing.Color.White;
            this.btnSubmitBid.Location = new System.Drawing.Point(230, 418);
            this.btnSubmitBid.Name = "btnSubmitBid";
            this.btnSubmitBid.Size = new System.Drawing.Size(143, 65);
            this.btnSubmitBid.TabIndex = 20;
            this.btnSubmitBid.Text = "Submit Bid";
            this.btnSubmitBid.Click += new System.EventHandler(this.btnSubmitBid_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(451, 418);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 65);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(291, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 45);
            this.label3.TabIndex = 22;
            this.label3.Text = "Bidding System";
            // 
            // BidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(864, 545);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmitBid);
            this.Controls.Add(this.txtEstimatedDays);
            this.Controls.Add(this.txtBidAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BidForm";
            this.Text = "BidForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BidForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtBidAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtEstimatedDays;
        private Guna.UI2.WinForms.Guna2Button btnSubmitBid;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label label3;
    }
}