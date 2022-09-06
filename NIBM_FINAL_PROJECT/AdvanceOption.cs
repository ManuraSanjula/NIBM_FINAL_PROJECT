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
    public partial class AdvanceOption : Form
    {
        public AdvanceOption()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new listView1().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ShowReports().Show();
        }
    }
}
