namespace VotingSystemApp
{
    partial class MainUI
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
            this.btnVoter = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoter
            // 
            this.btnVoter.Location = new System.Drawing.Point(37, 34);
            this.btnVoter.Name = "btnVoter";
            this.btnVoter.Size = new System.Drawing.Size(190, 70);
            this.btnVoter.TabIndex = 0;
            this.btnVoter.Text = "Voter";
            this.btnVoter.UseVisualStyleBackColor = true;
            this.btnVoter.Click += new System.EventHandler(this.btnVoter_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(37, 154);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(190, 70);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 276);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnVoter);
            this.Name = "MainUI";
            this.Text = "Election Commision";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoter;
        private System.Windows.Forms.Button btnAdmin;
    }
}

