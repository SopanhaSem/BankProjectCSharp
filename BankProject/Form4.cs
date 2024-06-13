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
        public void ShowWithdrawReport(string accno, string date, decimal currentBalance, decimal withdraw)
        {
            this.Hide();
            WithDrawReport reportForm = new WithDrawReport(accno, date, currentBalance, withdraw);
            reportForm.ShowDialog();
            this.Close();
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

                if (reader.Read())
                {
                    txtbalance.Text = reader[4].ToString();
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
                MessageBox.Show(ex.Message);
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

            accno = txtusername.Text.Trim();
            date = dateTimePicker1.Text;

            if (string.IsNullOrEmpty(accno) || string.IsNullOrEmpty(txtbalance.Text) || string.IsNullOrEmpty(txtwithdraw.Text))
            {
                EmptyTextInput emptyTextInput = new EmptyTextInput();
                emptyTextInput.ShowDialog();
                return;
            }

            if (!double.TryParse(txtbalance.Text, out bal) || !double.TryParse(txtwithdraw.Text, out withdraw))
            {
                NoAccountValCus noAccountValCus = new NoAccountValCus();
                noAccountValCus.ShowDialog();
                return;
            }

            if (withdraw <= 0)
            {
                MoneyValidation moneyValidation = new MoneyValidation();
                moneyValidation.ShowDialog();
                return;
            }

            if (withdraw > bal)
            {
                NoMoneyVal noMoneyVal = new NoMoneyVal();
                noMoneyVal.ShowDialog();
                return;
            }

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                MySqlTransaction transaction;

                transaction = con.BeginTransaction();
                cmd.Connection = con;
                cmd.Transaction = transaction;

                try
                {
                    cmd.CommandText = "SELECT balance FROM account WHERE accid = @accno";
                    cmd.Parameters.AddWithValue("@accno", accno);
                    double currentBalance = Convert.ToDouble(cmd.ExecuteScalar());

                    cmd.CommandText = "UPDATE account SET balance = balance - @withdraw WHERE accid = @accno";
                    cmd.Parameters.AddWithValue("@withdraw", withdraw);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO transaction(accid, date, bal, deposit, withdraw) VALUES (@accno, @date, @currentBalance, 0, @withdraw)";
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@currentBalance", currentBalance);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    decimal decimalCurrentBalance = Convert.ToDecimal(currentBalance);
                    decimal decimalWithdraw = Convert.ToDecimal(withdraw);
                    ShowWithdrawReport(accno, date, decimalCurrentBalance - decimalWithdraw, decimalWithdraw);

                    clear();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.ToString(), "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
