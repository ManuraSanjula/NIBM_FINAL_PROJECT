using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.reportTableAdapter1.Fill(this.reportDataSet.Report);
            this.reportViewer1.RefreshReport();
        }
    }
}
