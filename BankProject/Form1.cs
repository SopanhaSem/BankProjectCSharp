using Microsoft.VisualBasic;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace BankProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        MySqlConnection con = new MySqlConnection("server = localhost; database = bankdb; username = root;password = ;");

        public void cusId()
        {
            try
            {
                con.Open();

                string query = "select max(cusID) from customer";

                MySqlCommand cmd = new MySqlCommand(query, con);

                object result = cmd.ExecuteScalar();


                if (result != null && result != DBNull.Value)
                {
                    int maxCusID = Convert.ToInt32(result);
                    label14.Text = (maxCusID + 1).ToString();
                }
                else
                {
                    label14.Text = "1000";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cusId();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void txtbalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbalance_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string  lname, fname, street, city, state, phone, date, email, acno, actype, des, bal;
            lname = txtlname.Text;
            fname = txtfname.Text;
            street = txtstreet.Text;
            city = txtcity.Text;
            state = txtstate.Text;
            phone = txtphone.Text;
            date = dateTimePicker1.Text;
            email = txtemail.Text;
            acno = txtaccno.Text;
            actype = cbacctype.Text;
            des = txtdes.Text;
            bal = txtbalance.Text;

            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            MySqlTransaction transation;

            transation  = con.BeginTransaction();

            cmd.Connection = con;
            cmd.Transaction = transation;

            try
            {
                cmd.CommandText = "INSERT INTO customer(lastname, firstname, street, city, state, phone, date, email) " +
                        "VALUES (@lname, @fname, @street, @city, @state, @phone, @date, @email)";
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@street", street);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@state", state);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO account(accid, custID, accType, description, balance) " +
                        "VALUES (@acno, LAST_INSERT_ID(), @actype, @des, @bal)";
                cmd.Parameters.AddWithValue("@acno", acno);
                cmd.Parameters.AddWithValue("@actype", actype);
                cmd.Parameters.AddWithValue("@des", des);
                cmd.Parameters.AddWithValue("@bal", bal);
                cmd.ExecuteNonQuery();

                transation.Commit();
                MessageBox.Show("Record add");


            }
            catch (Exception ex)
            {
                transation.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }
    }
}