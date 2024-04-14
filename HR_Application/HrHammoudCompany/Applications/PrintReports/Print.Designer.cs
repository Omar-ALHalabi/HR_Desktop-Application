namespace HrHammoudCompany.Applications
{
    partial class Print
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
            this.reportViewer1Resignation = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1Resignation
            // 
            this.reportViewer1Resignation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportViewer1Resignation.DocumentMapWidth = 19;
            this.reportViewer1Resignation.LocalReport.ReportEmbeddedResource = "HrHammoudCompany.Applications.Reports.PrintResignation.rdlc";
            this.reportViewer1Resignation.Location = new System.Drawing.Point(111, 2);
            this.reportViewer1Resignation.Name = "reportViewer1Resignation";
            this.reportViewer1Resignation.ServerReport.BearerToken = null;
            this.reportViewer1Resignation.Size = new System.Drawing.Size(869, 830);
            this.reportViewer1Resignation.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1082, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "طباعة كشف تسليم العهدة";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1111, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "طباعة الإستقالة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HrHammoudCompany.Applications.Reports.reportHonesty.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(111, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(869, 830);
            this.reportViewer1.TabIndex = 6;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 837);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1Resignation);
            this.Name = "Print";
            this.Text = "Print";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Print_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1Resignation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}