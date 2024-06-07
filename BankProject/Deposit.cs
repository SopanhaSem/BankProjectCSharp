using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace BankProject
{
    public partial class Deposit : Form
    {
        public Deposit()
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
        public void clear() 
        {
            txtaccno.Text = "";
            txtamount.Text = "";
            txtdeposit.Text = "";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string st = "select * from account where accid = '" + txtaccno.Text + "'";
                MySqlCommand cmd = new MySqlCommand(st, con);


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txtamount.Text = reader[4].ToString();
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

        private void btns_Click(object sender, EventArgs e)
        {
            string accno, date;
            double bal, deposit;


            accno = txtaccno.Text;
            date = dateTimePicker1.Text;
            bal = Convert.ToDouble(txtamount.Text);
            deposit = Convert.ToDouble(txtdeposit.Text);

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
                cmd.CommandText = "UPDATE account SET balance = balance + @deposit WHERE accid = @accno";
                cmd.Parameters.AddWithValue("@deposit", deposit);
                cmd.ExecuteNonQuery();

                // Insert transaction record
                cmd.CommandText = "INSERT INTO transaction(accid, date, bal, deposit, withdraw) VALUES (@accno, @date, @currentBalance, @deposit, 0)";
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
