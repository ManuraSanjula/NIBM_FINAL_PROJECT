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
    public partial class AddFood : Form
    {
        String id;
        SqlConnection con;
        SqlCommand cmd;
        String userName;
        public AddFood(String id, String name)
        {
            InitializeComponent();
            this.id = id;
            this.userName = name;
        }

        private void btn_submits_Click(object sender, EventArgs e)
        {
            String name = txt_name.Text;
            String desc = txt_des.Text;
            String othr_info = txt_other_info.Text;
            String nutrition = txt_nutrition_details.Text;
            int price = Convert.ToInt32(txt_price.Text);
            String img1 = txt_image_1.Text;
            String img2 = txt_image_2.Text;

            try
            {
                int personId = Convert.ToInt32(id);
                SqlCommand cmd = new SqlCommand("insert into Food values('" + personId + "', '" + name + "', '" + desc + "', '" + othr_info + "' ,'" + nutrition + "', '" + price + "', '" + img1 + "', '" + img2 + "')", con);

                if (name != "" & desc != "" & nutrition != "" & price > 0 & img1 != "" & img2 != "" & othr_info != "")
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
            catch (Exception ex)
            {
                MessageBox.Show("Data Not Saved To the Database ||" + ex.Message);
                ErroController.SendErrorData(ex.Message, ex.ToString());
            }

        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-2MIJHAB9;Initial Catalog=NIBM;Integrated Security=True");
            txt_user_id.Text = userName;
        }
    }
}
