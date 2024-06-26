﻿using MySql.Data.MySqlClient;
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
        void clearText()
        {
            txtpass.Text = "";
            textBox1.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = txtpass.Text;

            if (ValidateLogin(username, password))
            {
                this.Hide();
                Session.Username = username; // Set the username in the session
                ProgressBar progressBar = new ProgressBar();
                progressBar.ShowDialog();
                this.Close();
        
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                clearText();
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
                            if (!string.IsNullOrEmpty(storedHash) && password == storedHash)
                            {
                                // Optionally update LastLogin timestamp
                                UpdateLastLogin(conn, username);
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password");
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return false;
                }
            }
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
            textBox1.TabStop = false;
            txtpass.TabStop = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
