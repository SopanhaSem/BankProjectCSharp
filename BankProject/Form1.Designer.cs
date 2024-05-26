namespace BankProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtfname = new TextBox();
            txtemail = new TextBox();
            label4 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtcity = new TextBox();
            label8 = new Label();
            txtphone = new TextBox();
            label7 = new Label();
            txtstate = new TextBox();
            label6 = new Label();
            txtstreet = new TextBox();
            label5 = new Label();
            txtlname = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            cbacctype = new ComboBox();
            label13 = new Label();
            txtdes = new TextBox();
            label12 = new Label();
            txtbalance = new TextBox();
            label11 = new Label();
            txtaccno = new TextBox();
            label10 = new Label();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 82);
            pictureBox1.Margin = new Padding(4, 7, 4, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 292);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Battambang", 14.25F);
            label2.Location = new Point(10, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 34);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            label2.Click += label2_Click;
            // 
            // txtfname
            // 
            txtfname.Font = new Font("Kh Battambang", 14.25F);
            txtfname.Location = new Point(10, 50);
            txtfname.Margin = new Padding(4, 7, 4, 7);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(347, 43);
            txtfname.TabIndex = 3;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Kh Battambang", 14.25F);
            txtemail.Location = new Point(394, 300);
            txtemail.Margin = new Padding(4, 7, 4, 7);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(347, 43);
            txtemail.TabIndex = 12;
            txtemail.TextChanged += txtbalance_TextChanged;
            txtemail.KeyPress += txtbalance_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kh Battambang", 14.25F);
            label4.Location = new Point(397, 263);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 34);
            label4.TabIndex = 13;
            label4.Text = "Email";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(340, 27);
            tabControl1.Margin = new Padding(4, 7, 4, 7);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(783, 472);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(txtcity);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(txtphone);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtstate);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtstreet);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtlname);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtfname);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtemail);
            tabPage1.Location = new Point(4, 43);
            tabPage1.Margin = new Padding(4, 7, 4, 7);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 7, 4, 7);
            tabPage1.Size = new Size(775, 425);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Customer";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Kh Battambang", 14.25F);
            label9.Location = new Point(10, 263);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(52, 34);
            label9.TabIndex = 25;
            label9.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Kh Battambang", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(7, 300);
            dateTimePicker1.Margin = new Padding(4, 7, 4, 7);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(347, 43);
            dateTimePicker1.TabIndex = 24;
            // 
            // txtcity
            // 
            txtcity.Font = new Font("Kh Battambang", 14.25F);
            txtcity.Location = new Point(397, 132);
            txtcity.Margin = new Padding(4, 7, 4, 7);
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(347, 43);
            txtcity.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Kh Battambang", 14.25F);
            label8.Location = new Point(400, 97);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(45, 34);
            label8.TabIndex = 22;
            label8.Text = "City";
            // 
            // txtphone
            // 
            txtphone.Font = new Font("Kh Battambang", 14.25F);
            txtphone.Location = new Point(397, 213);
            txtphone.Margin = new Padding(4, 7, 4, 7);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(347, 43);
            txtphone.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Kh Battambang", 14.25F);
            label7.Location = new Point(400, 178);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(69, 34);
            label7.TabIndex = 20;
            label7.Text = "Phone";
            // 
            // txtstate
            // 
            txtstate.Font = new Font("Kh Battambang", 14.25F);
            txtstate.Location = new Point(10, 213);
            txtstate.Margin = new Padding(4, 7, 4, 7);
            txtstate.Name = "txtstate";
            txtstate.Size = new Size(347, 43);
            txtstate.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Kh Battambang", 14.25F);
            label6.Location = new Point(13, 178);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(56, 34);
            label6.TabIndex = 18;
            label6.Text = "State";
            // 
            // txtstreet
            // 
            txtstreet.Font = new Font("Kh Battambang", 14.25F);
            txtstreet.Location = new Point(10, 132);
            txtstreet.Margin = new Padding(4, 7, 4, 7);
            txtstreet.Name = "txtstreet";
            txtstreet.Size = new Size(347, 43);
            txtstreet.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kh Battambang", 14.25F);
            label5.Location = new Point(13, 97);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 34);
            label5.TabIndex = 16;
            label5.Text = "Street";
            // 
            // txtlname
            // 
            txtlname.Font = new Font("Kh Battambang", 14.25F);
            txtlname.Location = new Point(397, 50);
            txtlname.Margin = new Padding(4, 7, 4, 7);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(347, 43);
            txtlname.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Battambang", 14.25F);
            label1.Location = new Point(397, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 34);
            label1.TabIndex = 14;
            label1.Text = "Last Name";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cbacctype);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(txtdes);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(txtbalance);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(txtaccno);
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4, 7, 4, 7);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 7, 4, 7);
            tabPage2.Size = new Size(775, 444);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Account";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbacctype
            // 
            cbacctype.Font = new Font("Kh Battambang", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbacctype.FormattingEnabled = true;
            cbacctype.Items.AddRange(new object[] { "Saving Account", "Bussiness Account" });
            cbacctype.Location = new Point(393, 44);
            cbacctype.Margin = new Padding(4, 7, 4, 7);
            cbacctype.Name = "cbacctype";
            cbacctype.Size = new Size(347, 42);
            cbacctype.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Kh Battambang", 14.25F);
            label13.Location = new Point(396, 6);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(127, 34);
            label13.TabIndex = 10;
            label13.Text = "Account Type";
            // 
            // txtdes
            // 
            txtdes.Font = new Font("Kh Battambang", 14.25F);
            txtdes.Location = new Point(8, 126);
            txtdes.Margin = new Padding(4, 7, 4, 7);
            txtdes.Name = "txtdes";
            txtdes.Size = new Size(347, 43);
            txtdes.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Kh Battambang", 14.25F);
            label12.Location = new Point(11, 88);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(107, 34);
            label12.TabIndex = 8;
            label12.Text = "Description";
            // 
            // txtbalance
            // 
            txtbalance.Font = new Font("Kh Battambang", 14.25F);
            txtbalance.Location = new Point(393, 126);
            txtbalance.Margin = new Padding(4, 7, 4, 7);
            txtbalance.Name = "txtbalance";
            txtbalance.Size = new Size(347, 43);
            txtbalance.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Kh Battambang", 14.25F);
            label11.Location = new Point(395, 88);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(82, 34);
            label11.TabIndex = 6;
            label11.Text = "Balance";
            // 
            // txtaccno
            // 
            txtaccno.Font = new Font("Kh Battambang", 14.25F);
            txtaccno.Location = new Point(8, 44);
            txtaccno.Margin = new Padding(4, 7, 4, 7);
            txtaccno.Name = "txtaccno";
            txtaccno.Size = new Size(347, 43);
            txtaccno.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Kh Battambang", 14.25F);
            label10.Location = new Point(11, 6);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(111, 34);
            label10.TabIndex = 4;
            label10.Text = "Account No";
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Location = new Point(50, 388);
            button2.Margin = new Padding(4, 7, 4, 7);
            button2.Name = "button2";
            button2.Size = new Size(127, 56);
            button2.TabIndex = 15;
            button2.Text = "Save";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Location = new Point(50, 449);
            button3.Margin = new Padding(4, 7, 4, 7);
            button3.Name = "button3";
            button3.Size = new Size(127, 59);
            button3.TabIndex = 16;
            button3.Text = "Close";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(185, 388);
            button1.Margin = new Padding(4, 7, 4, 7);
            button1.Name = "button1";
            button1.Size = new Size(127, 59);
            button1.TabIndex = 17;
            button1.Text = "Clear";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1154, 581);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(tabControl1);
            Font = new Font("Kh Battambang", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 7, 4, 7);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtfname;
        private TextBox txtemail;
        private Label label4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtcity;
        private Label label8;
        private TextBox txtphone;
        private Label label7;
        private TextBox txtstate;
        private Label label6;
        private TextBox txtstreet;
        private Label label5;
        private TextBox txtlname;
        private Label label1;
        private TabPage tabPage2;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbacctype;
        private Label label13;
        private TextBox txtdes;
        private Label label12;
        private TextBox txtbalance;
        private Label label11;
        private TextBox txtaccno;
        private Label label10;
        private Button button2;
        private Button button3;
        private Button button1;
    }
}
