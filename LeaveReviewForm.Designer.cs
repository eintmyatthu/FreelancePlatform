namespace FreelancePlatform
{
    partial class LeaveReviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveReviewForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtReviewText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmitReview = new Guna.UI2.WinForms.Guna2Button();
            this.cboRating = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(104, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rating: ";
            // 
            // txtReviewText
            // 
            this.txtReviewText.Location = new System.Drawing.Point(255, 268);
            this.txtReviewText.Multiline = true;
            this.txtReviewText.Name = "txtReviewText";
            this.txtReviewText.Size = new System.Drawing.Size(522, 267);
            this.txtReviewText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(90, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Review Text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(378, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Leave Your Review";
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Animated = true;
            this.btnSubmitReview.AutoRoundedCorners = true;
            this.btnSubmitReview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmitReview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmitReview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmitReview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmitReview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmitReview.ForeColor = System.Drawing.Color.White;
            this.btnSubmitReview.Location = new System.Drawing.Point(410, 580);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(161, 72);
            this.btnSubmitReview.TabIndex = 6;
            this.btnSubmitReview.Text = "Submit Review";
            this.btnSubmitReview.Click += new System.EventHandler(this.btnSubmitReview_Click);
            // 
            // cboRating
            // 
            this.cboRating.BackColor = System.Drawing.Color.Transparent;
            this.cboRating.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRating.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboRating.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboRating.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboRating.ItemHeight = 30;
            this.cboRating.Items.AddRange(new object[] {
            "Select Rate",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboRating.Location = new System.Drawing.Point(255, 155);
            this.cboRating.Name = "cboRating";
            this.cboRating.Size = new System.Drawing.Size(224, 36);
            this.cboRating.StartIndex = 0;
            this.cboRating.TabIndex = 7;
            // 
            // LeaveReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1050, 695);
            this.Controls.Add(this.cboRating);
            this.Controls.Add(this.btnSubmitReview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReviewText);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LeaveReviewForm";
            this.Text = "LeaveReviewForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LeaveReviewForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReviewText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnSubmitReview;
        private Guna.UI2.WinForms.Guna2ComboBox cboRating;
    }
}