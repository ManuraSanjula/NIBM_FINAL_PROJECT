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

namespace NIBM_FINAL_PROJECT
{
    public partial class DeleteUserHealthInfo : Form
    {
        int id;
        SqlConnection con;
        SqlCommand cmd;
        public DeleteUserHealthInfo(String id)
        {
            InitializeComponent();
            this.id = Convert.ToInt32(id) ;
        }

        private void DeleteUserHealthInfo_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-2MIJHAB9;Initial Catalog=NIBM;Integrated Security=True");
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            string query = "Delete from PersonalHealth where PersonID= '" + this.id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                MessageBox.Show("successfully data Deleted", "user information");
                while (myreader.Read())
                {
                }
                con.Close();
                this.Hide();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }  

        

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
