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
    public partial class TransferReport : Form
    {
        public TransferReport( string date, string fno,string tono, decimal transfer)
        {
            InitializeComponent();
            lblAccNo.Text = fno;
            //lblDate.Text = date;
            lblbl.Text = tono;
            lblDeposit.Text = transfer.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer transfer = new Transfer();
            transfer.ShowDialog();
            this.Close();
        }
    }
}
