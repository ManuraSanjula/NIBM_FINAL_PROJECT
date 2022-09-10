using Microsoft.VisualBasic;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NIBM_FINAL_PROJECT
{
    public partial class DeleteFoods : Form
    {
        String foodName;
        SqlConnection con;
        SqlCommand cmd;
        String id;

        public DeleteFoods(String id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            if (foodName == null || foodName == "")
            {
                MessageBox.Show("Please Enter Food Name");
                this.Hide();
                this.Close();
                return;
            }
            else
            {
                string query = "Delete from Food where Name= '" + this.foodName + "' And PersonID = '"+ Convert.ToInt32(id) +"' ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myreader;
                try
                {
                    con.Open();
                    myreader = cmd.ExecuteReader();

                    MessageBox.Show("Successfully data Deleted", "user information");
                    this.Hide();
                    con.Close();
 
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void DeleteFoods_Load(object sender, EventArgs e)
        {
            foodName = Interaction.InputBox("Enter Food Name", "Enter Food Name", "");
            con = new SqlConnection("Data Source=LAPTOP-2MIJHAB9;Initial Catalog=NIBM;Integrated Security=True");
        }
    }
}
