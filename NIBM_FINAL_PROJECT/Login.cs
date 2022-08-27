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
    public partial class Login : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        String userId;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String userName = txt_username.Text;
            String password = txt_password.Text;

            if (userName == "" & password == "")
            {
                MessageBox.Show("Please Enter UserName  and Password");
                return;
            }
               
            try
            {
                cmd = new SqlCommand("select * from Person where UserName = '"+userName+"'", con);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userId = reader[0].ToString();
                        MessageBox.Show("Login Succesfully");
                        con.Close();
                        this.Hide();
                        new Form1(userId, userName).Show();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-2MIJHAB9;Initial Catalog=NIBM;Integrated Security=True");
        }
    }
}
