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
    public partial class DepositReport : Form
    {
        public DepositReport(string accno, string date, decimal currentBalance, decimal deposit)
        {
            InitializeComponent();
            lblAccNo.Text = accno;
            //lblDate.Text = date;
            lblbl.Text = currentBalance.ToString("C");
            lblDeposit.Text = deposit.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit deposit = new Deposit();
            deposit.ShowDialog();
            this.Close();
        }
    }
}
