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
using System.Xml.Linq;

namespace NIBM_FINAL_PROJECT
{
    public partial class Report : Form
    {
        SqlConnection con;
        int userId;
        String name;
        public Report(int userId, String name)
        {
            this.name = name;
            this.userId = userId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String report = textBox1.Text;
                SqlCommand cmd = new SqlCommand("insert into Report values('" + userId + "', '" + report + "')", con);

                if (userId != null & report != "")
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
                }
                else
                {
                    MessageBox.Show("Missing Required Fields ");
                }

            }
            catch (Exception ex)
            {
                con.Close();
                ErroController.SendErrorData(ex.Message, ex.ToString());
                MessageBox.Show("Error Occur");
            }
        }

        private void Report_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-2MIJHAB9;Initial Catalog=NIBM;Integrated Security=True");
            user_name.Text = name;
            user_id.Text = userId.ToString();
        }
    }
}
