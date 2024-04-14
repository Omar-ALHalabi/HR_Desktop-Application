namespace HrHammoudCompany.Applications
{
    partial class PrintHealthyForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hr_HammoudCompanyDataSet3 = new HrHammoudCompany.Hr_HammoudCompanyDataSet3();
            this.printHealthFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printHealthFormTableAdapter = new HrHammoudCompany.Hr_HammoudCompanyDataSet3TableAdapters.printHealthFormTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hr_HammoudCompanyDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printHealthFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.printHealthFormBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HrHammoudCompany.Applications.Reports.ReportHealthForm.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(784, 470);
            this.reportViewer1.TabIndex = 0;
            // 
            // hr_HammoudCompanyDataSet3
            // 
            this.hr_HammoudCompanyDataSet3.DataSetName = "Hr_HammoudCompanyDataSet3";
            this.hr_HammoudCompanyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printHealthFormBindingSource
            // 
            this.printHealthFormBindingSource.DataMember = "printHealthForm";
            this.printHealthFormBindingSource.DataSource = this.hr_HammoudCompanyDataSet3;
            // 
            // printHealthFormTableAdapter
            // 
            this.printHealthFormTableAdapter.ClearBeforeFill = true;
            // 
            // PrintHealthyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 470);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrintHealthyForm";
            this.Text = "PrintHealthyForm";
            this.Load += new System.EventHandler(this.PrintHealthyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hr_HammoudCompanyDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printHealthFormBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource printHealthFormBindingSource;
        public Hr_HammoudCompanyDataSet3 hr_HammoudCompanyDataSet3;
        private Hr_HammoudCompanyDataSet3TableAdapters.printHealthFormTableAdapter printHealthFormTableAdapter;
    }
}