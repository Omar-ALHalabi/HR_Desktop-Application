namespace HrHammoudCompany.Users
{
    partial class InfoUsers
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
            this.userCard2 = new HrHammoudCompany.UserCard();
            this.SuspendLayout();
            // 
            // userCard2
            // 
            this.userCard2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userCard2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userCard2.Location = new System.Drawing.Point(8, 18);
            this.userCard2.Name = "userCard2";
            this.userCard2.Size = new System.Drawing.Size(1124, 588);
            this.userCard2.TabIndex = 0;
            // 
            // InfoUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 618);
            this.Controls.Add(this.userCard2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InfoUsers";
            this.Text = "InfoUsers";
            this.Load += new System.EventHandler(this.InfoUsers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserCard userCard2;
    }
}