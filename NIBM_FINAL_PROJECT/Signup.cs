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
    public partial class Signup : Form
    {
        SqlConnection con;
        public Signup()
        {
            InitializeComponent();
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            try
            {
                String userName = txt_username.Text;
                String password = txt_password.Text;
               
                SqlCommand cmd = new SqlCommand("insert into Person values('" + userName + "', '" + password + "')", con);

                if (userName != "" & password != "")
                {
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    con.Close();

                    if (i != 0)
                    {
                        MessageBox.Show("Data Saved");
                        new Form1().Show();
                        this.Close();
                    }
                    txt_password.Text = "";
                    txt_username.Text = "";

                }
                else
                {
                    MessageBox.Show("Missing Required Fields ");
                }
                    
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error Occur");
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-2MIJHAB9;Initial Catalog=NIBM;Integrated Security=True");
        }
    }
}
