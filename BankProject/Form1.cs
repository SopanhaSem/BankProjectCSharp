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
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            txtaccno.Text = "";
            txtbalance.Text = "";
            txtcity.Text = "";
            txtdes.Text = "";
            txtemail.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtphone.Text = "";
            txtstate.Text = "";
            txtstreet.Text = "";
            cbacctype.Items.Clear();
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
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string lname, fname, street, city, state, phone, date, email, acno, actype, des, bal;
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

            transation = con.BeginTransaction();

            cmd.Connection = con;
            cmd.Transaction = transation;
            if (string.IsNullOrWhiteSpace(lname) || string.IsNullOrWhiteSpace(fname) ||
            string.IsNullOrWhiteSpace(street) || string.IsNullOrWhiteSpace(city) ||
            string.IsNullOrWhiteSpace(state) || string.IsNullOrWhiteSpace(phone) ||
            string.IsNullOrWhiteSpace(date) || string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(acno) || string.IsNullOrWhiteSpace(actype) ||
            string.IsNullOrWhiteSpace(des) || string.IsNullOrWhiteSpace(bal))
            {
                EmptyTextInput emptyTextInput = new EmptyTextInput();
                emptyTextInput.ShowDialog();
                return;
            }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            clear();
        }
    }
}
