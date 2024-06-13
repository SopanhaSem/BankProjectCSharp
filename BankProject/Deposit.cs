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

                string st = "SELECT * FROM account WHERE accid = @accno";
                MySqlCommand cmd = new MySqlCommand(st, con);
                cmd.Parameters.AddWithValue("@accno", txtaccno.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtamount.Text = reader["balance"].ToString();
                }
                else
                {
                    NoAccountValCus noAccountValCus = new NoAccountValCus();
                    noAccountValCus.ShowDialog();
                    clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        public void ShowDepositReport(string accno, string date, decimal currentBalance, decimal deposit)
        {
            this.Hide();
            DepositReport reportForm = new DepositReport(accno, date, currentBalance, deposit);
            reportForm.ShowDialog();
            this.Close();
        }
        private void btns_Click(object sender, EventArgs e)
        {
            string accno = txtaccno.Text;
            string date = dateTimePicker1.Text;
            double deposit;

            if (string.IsNullOrWhiteSpace(accno) || !double.TryParse(txtdeposit.Text, out deposit))
            {
              EmptyTextInput emptyTextInput = new EmptyTextInput();
                emptyTextInput.ShowDialog();
                return;
            }

            if (deposit < 0)
            {
                MoneyValidation moneyValidation = new MoneyValidation();
                moneyValidation.ShowDialog();
                return;
            }

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT balance FROM account WHERE accid = @accno", con);
                cmd.Parameters.AddWithValue("@accno", accno);

                object result = cmd.ExecuteScalar();
                if (result == null)
                {
                    //MessageBox.Show("User not found");
                    clear();
                    return;
                }

                double currentBalance = Convert.ToDouble(result);

                MySqlTransaction transaction = con.BeginTransaction();
                cmd.Transaction = transaction;

                try
                {

                    cmd.CommandText = "UPDATE account SET balance = balance + @deposit WHERE accid = @accno";
                    cmd.Parameters.AddWithValue("@deposit", deposit);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO transaction(accid, date, bal, deposit, withdraw) VALUES (@accno, @date, @currentBalance, @deposit, 0)";
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@currentBalance", currentBalance);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();

                    ShowDepositReport(accno, date, (decimal)(currentBalance + deposit), (decimal)deposit);
                    clear();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void txtamount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
