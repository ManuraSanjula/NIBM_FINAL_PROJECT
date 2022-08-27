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
        //string input = "...";

        /* private static DialogResult ShowInputDialogBox(ref string input, string prompt, string title = "Title", int width = 300, int height = 200)
         {
             //This function creates the custom input dialog box by individually creating the different window elements and adding them to the dialog box

             //Specify the size of the window using the parameters passed
             Size size = new Size(width, height);
             //Create a new form using a System.Windows Form
             Form inputBox = new Form();

             inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
             inputBox.ClientSize = size;
             //Set the window title using the parameter passed
             inputBox.Text = title;

             //Create a new label to hold the prompt
             Label label = new Label();
             label.Text = prompt;
             label.Location = new Point(5, 5);
             label.Width = size.Width - 10;
             inputBox.Controls.Add(label);

             //Create a textbox to accept the user's input
             TextBox textBox = new TextBox();
             textBox.Size = new Size(size.Width - 10, 23);
             textBox.Location = new Point(5, label.Location.Y + 20);
             textBox.Text = input;
             inputBox.Controls.Add(textBox);

             //Create an OK Button 
             Button okButton = new Button();
             okButton.DialogResult = DialogResult.OK;
             okButton.Name = "okButton";
             okButton.Size = new Size(75, 23);
             okButton.Text = "&OK";
             okButton.Location = new Point(size.Width - 80 - 80, size.Height - 30);
             inputBox.Controls.Add(okButton);

             //Create a Cancel Button
             Button cancelButton = new Button();
             cancelButton.DialogResult = DialogResult.Cancel;
             cancelButton.Name = "cancelButton";
             cancelButton.Size = new Size(55, 23);
             cancelButton.Text = "&Cancel";
             cancelButton.Location = new Point(size.Width - 80, size.Height - 30);
             inputBox.Controls.Add(cancelButton);

             //Set the input box's buttons to the created OK and Cancel Buttons respectively so the window appropriately behaves with the button clicks
             inputBox.AcceptButton = okButton;
             inputBox.CancelButton = cancelButton;

             //Show the window dialog box 
             DialogResult result = inputBox.ShowDialog();
             input = textBox.Text;

             //After input has been submitted, return the input value
             return result;
         }*/

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
                        while (reader.Read())
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

                        }
                    }
                    con.Close();
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
