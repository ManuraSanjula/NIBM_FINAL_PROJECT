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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NIBM_FINAL_PROJECT
{
    public partial class AddHealthInformation : Form
    {
        String id;
        SqlConnection con;
        SqlCommand cmd;
        String userName;
        public AddHealthInformation(String id, String name)
        {
            InitializeComponent();
            this.id = id;
            this.userName = name;
        }

        public AddHealthInformation()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int personId = Convert.ToInt32(id);

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

            try
            {
                SqlCommand cmd = new SqlCommand("insert into PersonalHealth values('" + personId + "', '" + name + "', '" + blood_type + "', '" + age + "', '" + height + "', '" + weigth + "', '" + gender + "')", con);

                if (personId != null & name != "" & blood_type != "" & age > 0 & height != "" & weigth != "" & gender != "")
                {
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    con.Close();

                    if (i != 0)
                    {
                        MessageBox.Show("Data Saved");
                    }

                }
                else
                {
                    MessageBox.Show("Missing Required Fields ");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Data Not Saved To the Database");
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddHealthInformation_Load(object sender, EventArgs e)
        {
            if (id == null)
            {
                MessageBox.Show("Please LogIn");
                this.Hide();
            }
            else
            {
                con = new SqlConnection("Data Source=LAPTOP-2MIJHAB9;Initial Catalog=NIBM;Integrated Security=True");
                txt_name.Text = userName;
            }

        }
    }
}
