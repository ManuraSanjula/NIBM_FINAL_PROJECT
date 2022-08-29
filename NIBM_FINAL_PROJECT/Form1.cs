using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NIBM_FINAL_PROJECT
{
    public partial class Form1 : Form
    {
        private String id;
        String name, blood_type, gender;
        int age;
        float heigth, weight; 
             
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(String id, String name)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddHealthInformation_Click(object sender, EventArgs e)
        {
            if (id == null)
                MessageBox.Show("Please Loging To System");
            else
                new AddHealthInformation(id, name).Show();
        }

        private void UpdateHealthStatus_Click(object sender, EventArgs e)
        {
            if (id == null)
                MessageBox.Show("Please Loging To System");
            else
                new UpdateHealthStatus(id).Show();
            
        }

        private void DeleteHealthRecords_Click(object sender, EventArgs e)
        {
            if (id == null)
                MessageBox.Show("Please Loging To System");
            else
                new DeleteUserHealthInfo(id).Show();
        }

        private void GetHealthInfo_Click(object sender, EventArgs e)
        {
            if (id == null)
                MessageBox.Show("Please Loging To System");
            else
                new HealthDetail(id).Show();
        }

        private void AddFood_Click(object sender, EventArgs e)
        {
            if (id == null)
                MessageBox.Show("Please Loging To System");
            else
                new AddFood(id,name).Show();
        }

        private void UpdateFoods_Click(object sender, EventArgs e)
        {
            if (id == null)
                MessageBox.Show("Please Loging To System");
            else
                new UpdateFoods(name).Show();
        }

        private void FindsFood_Click(object sender, EventArgs e)
        {
            if (id == null)
                MessageBox.Show("Please Loging To System");
            else
                new FindsFood().Show();
        }

        private void DeleteFoods_Click(object sender, EventArgs e)
        {
            if (id == null)
                MessageBox.Show("Please Loging To System");
            else
                new DeleteFoods().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Signup().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
