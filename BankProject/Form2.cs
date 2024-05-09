using MySql.Data.MySqlClient;
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

namespace BankProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server = localhost; database = bankdb; username = root;password = ;");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM transaction", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    // Get the selected row
            //    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            //    // Get the ID of the selected row
            //    string stid = selectedRow.Cells["tx_id"].Value.ToString();

            //    // Update the selected row with the values from the text boxes
            //    try
            //    {
            //        using (MySqlConnection con = new MySqlConnection("server=localhost;database=bankdb;username=root;password=;"))
            //        {
            //            con.Open();
            //            MySqlCommand cmd = con.CreateCommand();
            //            cmd.CommandText = "UPDATE staff SET stName = @stName, gender = @gender, position = @position, phone = @phone, hireDate = @hireDate WHERE stid = @stid";
            //            cmd.Parameters.AddWithValue("@stid", stid);
            //            cmd.Parameters.AddWithValue("@stName", txtstaffname.Text);
            //            cmd.Parameters.AddWithValue("@gender", comboBox1.Text);
            //            cmd.Parameters.AddWithValue("@position", txtpos.Text);
            //            cmd.Parameters.AddWithValue("@phone", txtphone.Text);
            //            cmd.Parameters.AddWithValue("@hireDate", dateTimePicker1.Value);
            //            cmd.ExecuteNonQuery();
            //            MessageBox.Show("Record updated successfully.");

            //            // Refresh DataGridView with updated data from the database
            //            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM staff", con);
            //            DataTable dt = new DataTable();
            //            adapter.Fill(dt);
            //            dataGridView1.DataSource = dt;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please select a row to update.");
            //}
        }

            private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {

        }
    }
}
