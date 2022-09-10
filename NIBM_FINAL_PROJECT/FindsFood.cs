using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NIBM_FINAL_PROJECT
{
    public partial class FindsFood : Form
    {
        String foodName;
        SqlConnection con;
        SqlCommand cmd;
        String userName;
        String id;

        public FindsFood(String id,String name){ 
       
            InitializeComponent();
            this.userName = name;
            this.id = id;
        }
        private void FindsFood_Load(object sender, EventArgs e)
        {
            
            con = new SqlConnection("Data Source=LAPTOP-2MIJHAB9;Initial Catalog=NIBM;Integrated Security=True");
            txt_user_id.Text = userName;
            foodName = Interaction.InputBox("Enter Food Name", "Enter Food Name", "");
            if (foodName == null || foodName == "")
            {
                MessageBox.Show("Please Enter Food Name");
                this.Hide();
                this.Close();
                return;
            }
            try
            {
                cmd = new SqlCommand("select * from Food WHERE Name = '" + foodName + "' And PersonID = '"+ Convert.ToInt32(id) + "' ", con);
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
                       
                        var request = WebRequest.Create(reader[7].ToString());
                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            pictureBox1.Image = Bitmap.FromStream(stream);
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                        }

                        request = WebRequest.Create(reader[8].ToString());
                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            pictureBox2.Image = Bitmap.FromStream(stream);
                            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                        }
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
                this.Close();
                return;
            }
        }
    }
}
