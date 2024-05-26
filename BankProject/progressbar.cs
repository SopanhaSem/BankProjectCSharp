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
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100) // Check if the value is less than 100
            {
                progressBar1.Value += 1;
            }
            else
            {
                timer1.Enabled = false; // Stop the timer
                Form3 f3 = new Form3();
                this.Hide();
                f3.Show();
            }
        }
    }
}
