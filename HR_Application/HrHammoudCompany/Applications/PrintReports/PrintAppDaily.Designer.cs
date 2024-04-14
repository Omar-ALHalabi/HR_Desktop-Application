namespace HrHammoudCompany.Applications.PrintReports
{
    partial class PrintAppDaily
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spPrintAppMonthlyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printApplications = new HrHammoudCompany.PrintApplications();
            this.spPrintReferencAddressMonthlyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_PrintAppMonthlyTableAdapter = new HrHammoudCompany.PrintApplicationsTableAdapters.sp_PrintAppMonthlyTableAdapter();
            this.sp_PrintReferencAddressMonthlyTableAdapter = new HrHammoudCompany.PrintApplicationsTableAdapters.sp_PrintReferencAddressMonthlyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spPrintAppMonthlyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPrintReferencAddressMonthlyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spPrintAppMonthlyBindingSource
            // 
            this.spPrintAppMonthlyBindingSource.DataMember = "sp_PrintAppMonthly";
            this.spPrintAppMonthlyBindingSource.DataSource = this.printApplications;
            // 
            // printApplications
            // 
            this.printApplications.DataSetName = "PrintApplications";
            this.printApplications.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spPrintReferencAddressMonthlyBindingSource
            // 
            this.spPrintReferencAddressMonthlyBindingSource.DataMember = "sp_PrintReferencAddressMonthly";
            this.spPrintReferencAddressMonthlyBindingSource.DataSource = this.printApplications;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spPrintAppMonthlyBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.spPrintReferencAddressMonthlyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HrHammoudCompany.Applications.Reports.RDLCApplicationJobDaily.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // sp_PrintAppMonthlyTableAdapter
            // 
            this.sp_PrintAppMonthlyTableAdapter.ClearBeforeFill = true;
            // 
            // sp_PrintReferencAddressMonthlyTableAdapter
            // 
            this.sp_PrintReferencAddressMonthlyTableAdapter.ClearBeforeFill = true;
            // 
            // PrintAppDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrintAppDaily";
            this.Text = "PrintAppDaily";
            this.Load += new System.EventHandler(this.PrintAppDaily_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spPrintAppMonthlyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPrintReferencAddressMonthlyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource spPrintAppMonthlyBindingSource;
        private PrintApplicationsTableAdapters.sp_PrintAppMonthlyTableAdapter sp_PrintAppMonthlyTableAdapter;
        private PrintApplicationsTableAdapters.sp_PrintReferencAddressMonthlyTableAdapter sp_PrintReferencAddressMonthlyTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public PrintApplications printApplications;
        public System.Windows.Forms.BindingSource spPrintReferencAddressMonthlyBindingSource;
    }
}