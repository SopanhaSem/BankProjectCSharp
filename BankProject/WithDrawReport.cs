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
    public partial class WithDrawReport : Form
    {
        public WithDrawReport(string accno, string date, decimal currentBalance, decimal withdraw)
        {
            InitializeComponent();
            lblAccNo.Text = accno;
            //lblDate.Text = date;
            lblbl.Text = currentBalance.ToString("C");
            lblDeposit.Text = withdraw.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
            this.Close();
        }
    }
}
