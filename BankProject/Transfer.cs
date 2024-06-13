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
        public void ShowTransferReport( string date, string fno,string tono, decimal transfer)
        {
            this.Hide();
            TransferReport reportForm = new TransferReport( date,fno,tono,  transfer);
            reportForm.ShowDialog();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fno, tono, date;
            double amount;

            fno = txtfacc.Text.Trim();
            tono = txttacc.Text.Trim();
            date = dateTimePicker1.Text;

            if (string.IsNullOrEmpty(fno) || string.IsNullOrEmpty(tono) || string.IsNullOrEmpty(txtamount.Text))
            {
                EmptyTextInput emptyTextInput = new EmptyTextInput();
                emptyTextInput.ShowDialog();
                return;
            }

            if (!double.TryParse(txtamount.Text, out amount) || amount <= 0)
            {
                MoneyValidation moneyValidation = new MoneyValidation();
                moneyValidation.ShowDialog();
                return;
            }

            try
            {
                con.Open();

                MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM account WHERE accid = @accid", con);
                checkCmd.Parameters.AddWithValue("@accid", fno);
                int fromAccountExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                checkCmd.Parameters.Clear();
                checkCmd.Parameters.AddWithValue("@accid", tono);
                int toAccountExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (fromAccountExists == 0 || toAccountExists == 0)
                {
                    NoAccountValCus noAccountValCus = new NoAccountValCus();
                    noAccountValCus.ShowDialog();
                    return;
                }

                MySqlCommand balanceCmd = new MySqlCommand("SELECT balance FROM account WHERE accid = @fno", con);
                balanceCmd.Parameters.AddWithValue("@fno", fno);
                double fromAccountBalance = Convert.ToDouble(balanceCmd.ExecuteScalar());

                if (fromAccountBalance < amount)
                {
                    NoMoneyVal noMoney = new NoMoneyVal();
                    noMoney.ShowDialog();
                    return;
                }

                MySqlCommand cmd = new MySqlCommand();
                MySqlTransaction transaction;

                transaction = con.BeginTransaction();

                cmd.Connection = con;
                cmd.Transaction = transaction;

                try
                {
                    cmd.CommandText = "UPDATE account SET balance = balance - @amount WHERE accid = @fno";
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@fno", fno);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.CommandText = "UPDATE account SET balance = balance + @amount WHERE accid = @tono";
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@tono", tono);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO transfer(f_acc, to_acc, date, amount) VALUES (@fno, @tono, @date, @amount)";
                    cmd.Parameters.AddWithValue("@fno", fno);
                    cmd.Parameters.AddWithValue("@tono", tono);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    decimal decimalWithdraw = Convert.ToDecimal(amount);
                    ShowTransferReport(date, fno, tono, decimalWithdraw);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
