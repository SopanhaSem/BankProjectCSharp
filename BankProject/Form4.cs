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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankProject
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();

        }
        MySqlConnection con = new MySqlConnection("server = localhost; database = bankdb; username = root;password = ;");
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            txtbalance.Text = "";
            txtusername.Text = "";
            txtwithdraw.Text = "";
        }
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        public double withDraw(double oba, double wda)
        {

            return oba - wda;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string st = "select * from account where accid = '" + txtusername.Text + "'";
                MySqlCommand cmd = new MySqlCommand(st, con);


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txtbalance.Text = reader[4].ToString();
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string accno, date;
            double bal, withdraw;


            accno = txtusername.Text;
            date = dateTimePicker1.Text;
            bal = Convert.ToDouble(txtbalance.Text);
            withdraw = Convert.ToDouble(txtwithdraw.Text);

            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            MySqlTransaction transation;

            transation = con.BeginTransaction();

            cmd.Connection = con;
            cmd.Transaction = transation;

            try
            {
                cmd.CommandText = "SELECT balance FROM account WHERE accid = @accno";
                cmd.Parameters.AddWithValue("@accno", accno);
                double currentBalance = Convert.ToDouble(cmd.ExecuteScalar());

                // Update account balance
                cmd.CommandText = "UPDATE account SET balance = balance - @withdraw WHERE accid = @accno";
                cmd.Parameters.AddWithValue("@withdraw", withdraw);
                cmd.ExecuteNonQuery();

                // Insert transaction record
                cmd.CommandText = "INSERT INTO transaction(accid, date, bal, deposit, withdraw) VALUES (@accno, @date, @currentBalance, 0, @withdraw)";
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@currentBalance", currentBalance);
                cmd.ExecuteNonQuery();

                transation.Commit();
                MessageBox.Show("Transaction Success.....");
                clear();

            }
            catch (Exception ex)
            {
                transation.Rollback();
                MessageBox.Show(ex.ToString());
                clear();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
