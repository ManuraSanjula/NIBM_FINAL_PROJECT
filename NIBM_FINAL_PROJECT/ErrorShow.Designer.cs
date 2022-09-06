namespace NIBM_FINAL_PROJECT
{
    partial class listView1
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
            this.nIBMDataSet = new NIBM_FINAL_PROJECT.NIBMDataSet();
            this.errorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorTableAdapter = new NIBM_FINAL_PROJECT.NIBMDataSetTableAdapters.ErrorTableAdapter();
            this.listView2 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.nIBMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nIBMDataSet
            // 
            this.nIBMDataSet.DataSetName = "NIBMDataSet";
            this.nIBMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorBindingSource
            // 
            this.errorBindingSource.DataMember = "Error";
            this.errorBindingSource.DataSource = this.nIBMDataSet;
            // 
            // errorTableAdapter
            // 
            this.errorTableAdapter.ClearBeforeFill = true;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 12);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(776, 426);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "listView1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorShow";
            this.Load += new System.EventHandler(this.ErrorShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nIBMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private NIBMDataSet nIBMDataSet;
        private System.Windows.Forms.BindingSource errorBindingSource;
        private NIBMDataSetTableAdapters.ErrorTableAdapter errorTableAdapter;
        private System.Windows.Forms.ListView listView2;
    }
}