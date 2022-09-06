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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NIBM_FINAL_PROJECT
{
    public partial class UpdateFoods : Form
    {
        String foodName;
        SqlConnection con;
        SqlCommand cmd;
        String userName;
        String id;
        public UpdateFoods(String id, String name)
        {
            InitializeComponent();
            this.userName = name;
            this.id = id;
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
                con.Open();

                cmd = new SqlCommand("UPDATE Food set Name = '" + name + "',Description = '" + desc + "', OtherInformation='" + othr_info + "', NutritionDetails = '" + nutrition + "', Price ='" + price + "', Image1 ='" + img1 + "', Image2 ='" + img2 + "' where Name = '" + foodName + "' And PersonID = '"+ Convert.ToInt32(id) +"' ", con);

                int __ = cmd.ExecuteNonQuery();
                con.Close();
                if (__ == 1)
                    MessageBox.Show("Data Updated Sucessfully");
                else
                    MessageBox.Show("Data Not Updated Sucessfully");
            }
            catch (Exception ex)
            {
                ErroController.SendErrorData(ex.Message, ex.ToString());
                this.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateFoods_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-2MIJHAB9;Initial Catalog=NIBM;Integrated Security=True");
            txt_user_id.Text = userName;
            foodName =  Interaction.InputBox("Enter Food Name", "Enter Food Name", "");
            if(foodName == null || foodName == "")
            {
                MessageBox.Show("Please Enter Food Name");
                this.Hide();
                this.Close();
                return;
            }
            try
            {
                cmd = new SqlCommand("select * from Food WHERE Name = '" + foodName + "' And PersonID = '"+ Convert.ToInt32(id) +"' ", con);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txt_name.Text = reader[2].ToString();
                        txt_des.Text = reader[3].ToString();
                        txt_other_info.Text = reader[4].ToString();
                        txt_nutrition_details.Text = reader[5].ToString();
                        txt_price.Text = reader[6].ToString();
                        txt_image_1.Text = reader[7].ToString();
                        txt_image_2.Text = reader[8].ToString();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data Not Found");
                        con.Close();
                        this.Hide();
                        this.Close();
                        return;
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErroController.SendErrorData(ex.Message, ex.ToString());
                this.Close();
                return;
            }
        }
    }
}
