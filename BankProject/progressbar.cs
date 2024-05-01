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
    public partial class progressbar : Form
    {
        public progressbar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;

            if (progressBar1.Value >= 99)
            {
                Form3 f3 = new Form3();
                this.Hide();
                f3.Show();

                timer1.Enabled = false;

                progressBar1.Value = progressBar1.Value - 1;
            }
        }

        private void progressbar_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
