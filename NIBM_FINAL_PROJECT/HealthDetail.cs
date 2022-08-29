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
    public partial class HealthDetail : Form
    {
        private String id;
        SqlConnection con;
        SqlCommand cmd;

        public HealthDetail(String id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void HealthDetail_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-2MIJHAB9;Initial Catalog=NIBM;Integrated Security=True");

            try
            {
                int user_id = Convert.ToInt32(id);
                cmd = new SqlCommand("select * from PersonalHealth WHERE PersonID = '" + user_id + "'", con);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txt_name.Text = reader[2].ToString();
                        txt_blood_type.Text = reader[3].ToString();
                        txt_age.Text = reader[4].ToString();
                        txt_height.Text = reader[5].ToString();
                        txt_weight.Text = reader[6].ToString();
                        if (reader[7].ToString() == "Male")
                        {
                            male.Checked = true;
                        }
                        else
                            female.Checked = true;
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data Not Found");
                        this.Hide();
                        this.Close();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
