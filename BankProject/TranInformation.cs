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

namespace BankProject
{
    public partial class TranInformation : Form
    {
        public TranInformation()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server = localhost; database = bankdb; username = root;password = ;");
        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void TranInformation_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM staff", con);
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

        private void listView1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the ID of the selected row
                string stid = selectedRow.Cells["stid"].Value.ToString();

                // Update the selected row with the values from the text boxes
                try
                {
                    using (MySqlConnection con = new MySqlConnection("server=localhost;database=bankdb;username=root;password=;"))
                    {
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "UPDATE staff SET stName = @stName, gender = @gender, position = @position, phone = @phone, hireDate = @hireDate WHERE stid = @stid";
                        cmd.Parameters.AddWithValue("@stid", stid);
                        cmd.Parameters.AddWithValue("@stName", txtstaffname.Text);
                        cmd.Parameters.AddWithValue("@gender", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@position", txtpos.Text);
                        cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                        cmd.Parameters.AddWithValue("@hireDate", dateTimePicker1.Value);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record updated successfully.");

                        // Refresh DataGridView with updated data from the database
                        MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM staff", con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;database=bankdb;username=root;password=;"))
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO staff (stid,stName, gender, position, phone, hireDate) VALUES (@stid,@stName, @gender, @position, @phone, @hireDate)";
                    cmd.Parameters.AddWithValue("@stid", txtstaffid.Text);
                    cmd.Parameters.AddWithValue("@stName", txtstaffname.Text);
                    cmd.Parameters.AddWithValue("@gender", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@position", txtpos.Text);
                    cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                    cmd.Parameters.AddWithValue("@hireDate", dateTimePicker1.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record added successfully.");

                    // Clear text boxes after adding a new record
                    ClearTextBoxes();

                    // Refresh DataGridView with updated data from the database
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM staff", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // Method to clear text boxes
        void ClearTextBoxes()
        {
            txtstaffid.Clear();
            txtstaffname.Clear();
            comboBox1.SelectedIndex = -1; // Clear selected item in ComboBox
            txtpos.Clear();
            txtphone.Clear();
            dateTimePicker1.Value = DateTime.Now; // Reset DateTimePicker to current date and time
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the values from the selected row
                string stid = selectedRow.Cells["stid"].Value.ToString();
                string stName = selectedRow.Cells["stName"].Value.ToString();
                string gender = selectedRow.Cells["gender"].Value.ToString();
                string position = selectedRow.Cells["position"].Value.ToString();
                string phone = selectedRow.Cells["phone"].Value.ToString();
                DateTime hireDate = Convert.ToDateTime(selectedRow.Cells["hireDate"].Value);

                // Populate the text boxes with the values from the selected row
                txtstaffid.Text = stid;
                txtstaffname.Text = stName;
                comboBox1.Text = gender;
                txtpos.Text = position;
                txtphone.Text = phone;
                dateTimePicker1.Value = hireDate;
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string stid = selectedRow.Cells["stid"].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection con = new MySqlConnection("server=localhost;database=bankdb;username=root;password=;"))
                        {
                            con.Open();
                            MySqlCommand cmd = con.CreateCommand();
                            cmd.CommandText = "DELETE FROM staff WHERE stid = @stid";
                            cmd.Parameters.AddWithValue("@stid", stid);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record deleted successfully.");

                            // Refresh DataGridView with updated data from the database
                            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM staff", con);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
