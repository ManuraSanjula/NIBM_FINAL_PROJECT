using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
 
namespace NIBM_FINAL_PROJECT
{
    public partial class listView1 : Form
    {

        String con = "Data Source=LAPTOP-2MIJHAB9;Initial Catalog=NIBM;Integrated Security=True";
        public listView1()
        {
            InitializeComponent();
        }

        private void ErrorShow_Load(object sender, EventArgs e)
        {
            listView2.GridLines = true;
            listView2.View = View.Details;
            //Add Column Header
            listView2.Columns.Add("ErrorId", 150);
            listView2.Columns.Add("Message", 150);
            listView2.Columns.Add("StringFormat", 150);

            // Chnage sqlquery and table name
            string sql = "select * from Error";
            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            listView2.Items.Clear();
            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                lv.SubItems.Add(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetString(2));
                listView2.Items.Add(lv);
            }
            Reader.Close();
            cnn.Close();
        }
    }
}
