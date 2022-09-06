using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NIBM_FINAL_PROJECT
{
    public partial class ShowReports : Form
    {
        String con = "Data Source=LAPTOP-2MIJHAB9;Initial Catalog=NIBM;Integrated Security=True";
        public ShowReports()
        {
            InitializeComponent();
        }

        private void ShowReports_Load(object sender, EventArgs e)
        {
            listView1.GridLines = true;
            listView1.View = View.Details;
            //Add Column Header
            listView1.Columns.Add("ID", 150);
            listView1.Columns.Add("PersonID", 150);
            listView1.Columns.Add("Report", 150);

            // Chnage sqlquery and table name
            string sql = "select * from Report";
            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                lv.SubItems.Add(Reader.GetInt32(1).ToString());
                lv.SubItems.Add(Reader.GetString(2));
                listView1.Items.Add(lv);
            }
            Reader.Close();
            cnn.Close();
        }
    }
}
