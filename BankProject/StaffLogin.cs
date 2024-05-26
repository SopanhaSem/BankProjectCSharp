using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
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
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            InitializeComponent();
        }
        private string connectionString = "server=localhost;database=bankdb;user=root;password=;";

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = txtpass.Text;

            if (ValidateLogin(username, password))
            {
                Session.Username = username; // Set the username in the session
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
        private bool ValidateLogin(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT PasswordHash FROM StaffLogin WHERE Username = @Username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string storedHash = result.ToString();
                            if (!string.IsNullOrEmpty(storedHash))
                            {
                                if (password == storedHash) // Simple password comparison
                                {
                                    // Optionally update LastLogin timestamp
                                    UpdateLastLogin(conn, username);
                                    return true;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            return false;
        }
        private void UpdateLastLogin(MySqlConnection conn, string username)
        {

            string updateQuery = "UPDATE StaffLogin SET LastLogin = CURRENT_TIMESTAMP WHERE Username = @Username";
            using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.ExecuteNonQuery();
            }
        }
        private void StaffLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
