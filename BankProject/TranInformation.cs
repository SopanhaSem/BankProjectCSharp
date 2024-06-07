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
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
            this.Close();
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
                dataGridView1.Columns["stid"].HeaderText = "ID";
                dataGridView1.Columns["stName"].HeaderText = "Name";
                dataGridView1.Columns["gender"].HeaderText = "Gender";
                dataGridView1.Columns["position"].HeaderText = "Position";
                dataGridView1.Columns["phone"].HeaderText = "Phone";
                dataGridView1.Columns["hiredate"].HeaderText = "Hired Date";
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
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string stid = selectedRow.Cells["stid"].Value.ToString();
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
                        ClearTextBoxes();
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
            if (
                string.IsNullOrEmpty(txtstaffname.Text) ||
                comboBox1.SelectedIndex == -1 ||
                string.IsNullOrEmpty(txtpos.Text) ||
                string.IsNullOrEmpty(txtphone.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
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
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtstaffid.Text) ||
                string.IsNullOrEmpty(txtstaffname.Text) ||
                comboBox1.SelectedIndex == -1 ||
                string.IsNullOrEmpty(txtpos.Text) ||
                string.IsNullOrEmpty(txtphone.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return false;
            }
            // Add more validation rules as needed
            return true;
        }
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string stid = selectedRow.Cells["stid"].Value.ToString();
                string stName = selectedRow.Cells["stName"].Value.ToString();
                string gender = selectedRow.Cells["gender"].Value.ToString();
                string position = selectedRow.Cells["position"].Value.ToString();
                string phone = selectedRow.Cells["phone"].Value.ToString();
                DateTime hireDate = Convert.ToDateTime(selectedRow.Cells["hireDate"].Value);
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
                            // Remove the selected row from the DataGridView
                            dataGridView1.Rows.Remove(selectedRow);
                            MessageBox.Show("Record deleted successfully.");
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

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}