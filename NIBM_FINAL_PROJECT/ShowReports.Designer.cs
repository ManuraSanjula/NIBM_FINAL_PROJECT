namespace NIBM_FINAL_PROJECT
{
    partial class ShowReports
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
            this.static_reports = new NIBM_FINAL_PROJECT.Static_reports();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportTableAdapter = new NIBM_FINAL_PROJECT.Static_reportsTableAdapters.ReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.static_reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "StaticReports";
            reportDataSource1.Value = this.reportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NIBM_FINAL_PROJECT.StaticReports.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(34, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(982, 563);
            this.reportViewer1.TabIndex = 0;
            // 
            // static_reports
            // 
            this.static_reports.DataSetName = "Static_reports";
            this.static_reports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "Report";
            this.reportBindingSource.DataSource = this.static_reports;
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // ShowReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 626);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShowReports";
            this.Text = "ShowReports";
            this.Load += new System.EventHandler(this.ShowReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.static_reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Static_reports static_reports;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private Static_reportsTableAdapters.ReportTableAdapter reportTableAdapter;
    }
}