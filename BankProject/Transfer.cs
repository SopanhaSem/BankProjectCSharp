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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server = localhost; database = bankdb; username = root;password = ;");
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fno, tono, date;
            double amount;

            fno = txtfacc.Text;
            tono = txttacc.Text;
            date = dateTimePicker1.Text;
            amount = Convert.ToDouble(txtamount.Text);

            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            MySqlTransaction transaction;

            transaction = con.BeginTransaction();

            cmd.Connection = con;
            cmd.Transaction = transaction;

            try
            {
                // Deduct amount from the sender's account
                cmd.CommandText = "UPDATE account SET balance = balance - @amount WHERE accid = @fno";
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@fno", fno);
                cmd.ExecuteNonQuery();

                // Add amount to the receiver's account
                cmd.CommandText = "UPDATE account SET balance = balance + @amount WHERE accid = @tono";
                cmd.Parameters.AddWithValue("@tono", tono);
                cmd.ExecuteNonQuery();

                // Insert transaction record for the transfer
                cmd.Parameters.Clear(); // Clear previous parameters
                cmd.CommandText = "INSERT INTO transfer(f_acc, to_acc, date, amount) VALUES (@fno, @tono, @date, @amount)";
                cmd.Parameters.AddWithValue("@fno", fno);
                cmd.Parameters.AddWithValue("@tono", tono);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Transfer Success.");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
