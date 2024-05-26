using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private string connectionString = "server=localhost;database=bankdb;user=root;password=;";
        private void Form3_Load(object sender, EventArgs e)
        {
            string username = Session.Username;
            label8.Text = username;
            label9.Text = DateTime.Now.ToLongTimeString();
        }
        //private string GetUsernameFromDatabase()
        //{
        //    string username = "";
        //    using (MySqlConnection conn = new MySqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            conn.Open();
        //            string query = "SELECT Username FROM StaffLogin"; // Assuming you want to retrieve the first username
        //            using (MySqlCommand cmd = new MySqlCommand(query, conn))
        //            {
        //                object result = cmd.ExecuteScalar();
        //                if (result != null)
        //                {
        //                    username = result.ToString();
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error: {ex.Message}");
        //        }
        //    }
        //    return username;
        //}
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Deposit form3 = new Deposit();
            form3.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Transfer form1 = new Transfer();
            form1.Show(); this.Hide(); this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            TranInformation form1 = new TranInformation();
            form1.Show(); this.Hide(); this.Close();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StaffLogin stf = new StaffLogin();
            stf.Show();
            this.Hide();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
