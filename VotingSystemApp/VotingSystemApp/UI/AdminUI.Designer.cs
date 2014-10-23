namespace VotingSystemApp
{
    partial class AdminUI
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
            this.btnEnterNoOfWinners = new System.Windows.Forms.Button();
            this.btnCandidate = new System.Windows.Forms.Button();
            this.btnViewResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnterNoOfWinners
            // 
            this.btnEnterNoOfWinners.Location = new System.Drawing.Point(49, 31);
            this.btnEnterNoOfWinners.Name = "btnEnterNoOfWinners";
            this.btnEnterNoOfWinners.Size = new System.Drawing.Size(183, 77);
            this.btnEnterNoOfWinners.TabIndex = 0;
            this.btnEnterNoOfWinners.Text = "No of winners";
            this.btnEnterNoOfWinners.UseVisualStyleBackColor = true;
            this.btnEnterNoOfWinners.Click += new System.EventHandler(this.btnEnterNoOfWinners_Click);
            // 
            // btnCandidate
            // 
            this.btnCandidate.Location = new System.Drawing.Point(49, 140);
            this.btnCandidate.Name = "btnCandidate";
            this.btnCandidate.Size = new System.Drawing.Size(183, 77);
            this.btnCandidate.TabIndex = 0;
            this.btnCandidate.Text = "Candidate";
            this.btnCandidate.UseVisualStyleBackColor = true;
            this.btnCandidate.Click += new System.EventHandler(this.btnCandidate_Click);
            // 
            // btnViewResult
            // 
            this.btnViewResult.Location = new System.Drawing.Point(49, 238);
            this.btnViewResult.Name = "btnViewResult";
            this.btnViewResult.Size = new System.Drawing.Size(183, 35);
            this.btnViewResult.TabIndex = 1;
            this.btnViewResult.Text = "View Result";
            this.btnViewResult.UseVisualStyleBackColor = true;
            this.btnViewResult.Click += new System.EventHandler(this.btnViewResult_Click);
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 288);
            this.Controls.Add(this.btnViewResult);
            this.Controls.Add(this.btnCandidate);
            this.Controls.Add(this.btnEnterNoOfWinners);
            this.Name = "AdminUI";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnterNoOfWinners;
        private System.Windows.Forms.Button btnCandidate;
        private System.Windows.Forms.Button btnViewResult;
    }
}