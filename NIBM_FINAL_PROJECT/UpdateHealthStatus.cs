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
    public partial class UpdateHealthStatus : Form
    {
        private String id;
        SqlConnection con;
        SqlCommand cmd;

        public UpdateHealthStatus()
        {
            InitializeComponent();
        }
        public UpdateHealthStatus(String id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void txt_height_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateHealthStatus_Load(object sender, EventArgs e)
        {
            if (id == null)
            {
                MessageBox.Show("Please LogIn");
                return;
            }
            else
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
                            con.Close();
                            this.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                }

            }


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int user_id = Convert.ToInt32(id);
                String name = txt_name.Text;
                String blood_type = txt_blood_type.Text;
                int age = Convert.ToInt32(txt_age.Text);
                String height = txt_height.Text;
                String weigth = txt_weight.Text;
                String gender = "";
                if (male.Checked)
                    gender = male.Text;
                else if (female.Checked)
                    gender = female.Text;

                con.Open();

                cmd = new SqlCommand("UPDATE PersonalHealth set Name = '" + name + "',BloodType = '" + blood_type + "', Age='" + age + "', Height = '" + height + "', Weight ='" + weigth + "', Gender ='" + gender + "' where PersonID = '" + user_id + "' ", con);

                int __ = cmd.ExecuteNonQuery();
                con.Close();
                if (__ == 1)
                    MessageBox.Show("Data Updated Sucessfully");
                else
                    MessageBox.Show("Data Not  Updated Sucessfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
