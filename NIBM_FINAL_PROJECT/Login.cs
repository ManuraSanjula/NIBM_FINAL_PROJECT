using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NIBM_FINAL_PROJECT
{
    public partial class Login : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        String userId = "";
        String name = "";
        Boolean userLogging;
        public Login(Boolean userLogging)
        {
            InitializeComponent();
            this.userLogging = userLogging;
        }

        public static bool IsNullOrEmpty(List<String> list)
        {
            return (list == null || list.Any());
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String userName = txt_username.Text;
            String password = txt_password.Text;

            if (userName == "" & password == "")
            {
                MessageBox.Show("Please Enter UserName and Password");
                return;
            }

            if (!userLogging)
            {
                if(userName == "Admin" & password == "asdfghjkl")
                {
                    new ShowReports().Show();
                    this.Close();
                }else
                    MessageBox.Show("Please Enter UserName and Password");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("select * from Person where UserName = '" + userName + "'", con);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        /*List<string> list = (from IDataRecord r in reader
                                             select (string)r["UserName Password Invalid"]
                        ).ToList();*/
                        if (reader.Read())
                        {
                            if (password == reader[2].ToString())
                            {
                                userId = reader[0].ToString();
                                name = reader[1].ToString();
                                new Form1(userId, name).Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("UserName Password Invalid");
                                this.Close();
                                new Form1(null, null).Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("UserName Password Invalid");
                            this.Close();
                            new Form1(null, null).Show();
                        }

                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Close();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-2MIJHAB9;Initial Catalog=NIBM;Integrated Security=True");
        }
    }
}
