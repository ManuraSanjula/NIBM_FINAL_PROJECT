using System;

using System.Windows.Forms;

namespace NIBM_FINAL_PROJECT
{
    public partial class ShowReports : Form
    {
        public ShowReports()
        {
            InitializeComponent();
        }

        private void ShowReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'static_reports.Report' table. You can move, or remove it, as needed.
            this.reportTableAdapter.Fill(this.static_reports.Report);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }
    }
}
