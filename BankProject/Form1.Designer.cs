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
            label14 = new Label();
            label3 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 306);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 74);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            label2.Click += label2_Click;
            // 
            // txtfname
            // 
            txtfname.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtfname.Location = new Point(21, 98);
            txtfname.Multiline = true;
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(244, 33);
            txtfname.TabIndex = 3;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(21, 575);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(244, 33);
            txtemail.TabIndex = 12;
            txtemail.TextChanged += txtbalance_TextChanged;
            txtemail.KeyPress += txtbalance_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 551);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 13;
            label4.Text = "Email";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(411, 701);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label3);
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
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(403, 673);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(134, 33);
            label14.Name = "label14";
            label14.Size = new Size(29, 21);
            label14.TabIndex = 27;
            label14.Text = "ID";
            label14.Click += label14_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 33);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 26;
            label3.Text = "Customer ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(21, 480);
            label9.Name = "label9";
            label9.Size = new Size(44, 21);
            label9.TabIndex = 25;
            label9.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(21, 514);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // txtcity
            // 
            txtcity.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcity.Location = new Point(21, 300);
            txtcity.Multiline = true;
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(244, 33);
            txtcity.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 276);
            label8.Name = "label8";
            label8.Size = new Size(41, 21);
            label8.TabIndex = 22;
            label8.Text = "City";
            // 
            // txtphone
            // 
            txtphone.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtphone.Location = new Point(21, 433);
            txtphone.Multiline = true;
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(244, 33);
            txtphone.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 409);
            label7.Name = "label7";
            label7.Size = new Size(57, 21);
            label7.TabIndex = 20;
            label7.Text = "Phone";
            // 
            // txtstate
            // 
            txtstate.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtstate.Location = new Point(21, 365);
            txtstate.Multiline = true;
            txtstate.Name = "txtstate";
            txtstate.Size = new Size(244, 33);
            txtstate.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 341);
            label6.Name = "label6";
            label6.Size = new Size(47, 21);
            label6.TabIndex = 18;
            label6.Text = "State";
            // 
            // txtstreet
            // 
            txtstreet.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtstreet.Location = new Point(21, 233);
            txtstreet.Multiline = true;
            txtstreet.Name = "txtstreet";
            txtstreet.Size = new Size(244, 33);
            txtstreet.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 209);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 16;
            label5.Text = "Street";
            // 
            // txtlname
            // 
            txtlname.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtlname.Location = new Point(21, 166);
            txtlname.Multiline = true;
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(244, 33);
            txtlname.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 142);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 14;
            label1.Text = "Last Name";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cbacctype);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(txtdes);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(txtbalance);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(txtaccno);
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(403, 673);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbacctype
            // 
            cbacctype.FormattingEnabled = true;
            cbacctype.Items.AddRange(new object[] { "Saving Account", "Bussiness Account" });
            cbacctype.Location = new Point(15, 105);
            cbacctype.Name = "cbacctype";
            cbacctype.Size = new Size(244, 23);
            cbacctype.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(15, 81);
            label13.Name = "label13";
            label13.Size = new Size(117, 21);
            label13.TabIndex = 10;
            label13.Text = "Account Type";
            // 
            // txtdes
            // 
            txtdes.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdes.Location = new Point(15, 174);
            txtdes.Multiline = true;
            txtdes.Name = "txtdes";
            txtdes.Size = new Size(244, 33);
            txtdes.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(15, 150);
            label12.Name = "label12";
            label12.Size = new Size(96, 21);
            label12.TabIndex = 8;
            label12.Text = "Description";
            // 
            // txtbalance
            // 
            txtbalance.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbalance.Location = new Point(15, 242);
            txtbalance.Multiline = true;
            txtbalance.Name = "txtbalance";
            txtbalance.Size = new Size(244, 33);
            txtbalance.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(15, 218);
            label11.Name = "label11";
            label11.Size = new Size(68, 21);
            label11.TabIndex = 6;
            label11.Text = "Balance";
            // 
            // txtaccno
            // 
            txtaccno.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtaccno.Location = new Point(15, 40);
            txtaccno.Multiline = true;
            txtaccno.Name = "txtaccno";
            txtaccno.Size = new Size(244, 33);
            txtaccno.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(15, 16);
            label10.Name = "label10";
            label10.Size = new Size(102, 21);
            label10.TabIndex = 4;
            label10.Text = "Account No";
            // 
            // button2
            // 
            button2.Location = new Point(478, 210);
            button2.Name = "button2";
            button2.Size = new Size(142, 71);
            button2.TabIndex = 15;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(478, 330);
            button3.Name = "button3";
            button3.Size = new Size(142, 72);
            button3.TabIndex = 16;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(658, 717);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(tabControl1);
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
        private Label label14;
        private Label label3;
    }
}
