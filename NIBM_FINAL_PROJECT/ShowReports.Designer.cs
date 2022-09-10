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
            this.reportDataSet = new NIBM_FINAL_PROJECT.ReportDataSet();
            this.reportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportTableAdapter1 = new NIBM_FINAL_PROJECT.ReportDataSetTableAdapters.ReportTableAdapter();
            this.ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NIBM_FINAL_PROJECT.Static_Report_2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 7);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1026, 607);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportDataSetBindingSource
            // 
            this.reportDataSetBindingSource.DataSource = this.reportDataSet;
            this.reportDataSetBindingSource.Position = 0;
            // 
            // reportTableAdapter1
            // 
            this.reportTableAdapter1.ClearBeforeFill = true;
            // 
            // ReportBindingSource
            // 
            this.ReportBindingSource.DataMember = "Report";
            this.ReportBindingSource.DataSource = this.reportDataSet;
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
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportDataSetBindingSource;
        private ReportDataSet reportDataSet;
        private ReportDataSetTableAdapters.ReportTableAdapter reportTableAdapter1;
        private System.Windows.Forms.BindingSource ReportBindingSource;
    }
}