namespace BankProject
{
    partial class TranInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranInformation));
            btnup = new Button();
            btnedit = new Button();
            btndel = new Button();
            button5 = new Button();
            txtstaffid = new TextBox();
            txtstaffname = new TextBox();
            txtphone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            txtpos = new TextBox();
            comboBox1 = new ComboBox();
            btnadd = new Button();
            pictureBox6 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // btnup
            // 
            btnup.BackColor = SystemColors.ActiveBorder;
            btnup.BackgroundImage = (Image)resources.GetObject("btnup.BackgroundImage");
            btnup.BackgroundImageLayout = ImageLayout.Zoom;
            btnup.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnup.Location = new Point(472, 758);
            btnup.Margin = new Padding(3, 4, 3, 4);
            btnup.Name = "btnup";
            btnup.Size = new Size(105, 47);
            btnup.TabIndex = 1;
            btnup.UseVisualStyleBackColor = false;
            btnup.Click += btnadd_Click;
            // 
            // btnedit
            // 
            btnedit.BackColor = SystemColors.ActiveBorder;
            btnedit.BackgroundImage = (Image)resources.GetObject("btnedit.BackgroundImage");
            btnedit.BackgroundImageLayout = ImageLayout.Zoom;
            btnedit.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnedit.Location = new Point(599, 758);
            btnedit.Margin = new Padding(3, 4, 3, 4);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(108, 47);
            btnedit.TabIndex = 2;
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // btndel
            // 
            btndel.BackColor = SystemColors.ActiveBorder;
            btndel.BackgroundImage = (Image)resources.GetObject("btndel.BackgroundImage");
            btndel.BackgroundImageLayout = ImageLayout.Zoom;
            btndel.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndel.ImageAlign = ContentAlignment.MiddleLeft;
            btndel.Location = new Point(728, 758);
            btndel.Margin = new Padding(3, 4, 3, 4);
            btndel.Name = "btndel";
            btndel.Size = new Size(98, 47);
            btndel.TabIndex = 3;
            btndel.UseVisualStyleBackColor = false;
            btndel.Click += btndel_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(12, 18);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(124, 41);
            button5.TabIndex = 8;
            button5.Text = "←";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // txtstaffid
            // 
            txtstaffid.Font = new Font("Kh Battambang", 14.25F);
            txtstaffid.Location = new Point(24, 129);
            txtstaffid.Margin = new Padding(3, 4, 3, 4);
            txtstaffid.Name = "txtstaffid";
            txtstaffid.ReadOnly = true;
            txtstaffid.Size = new Size(200, 43);
            txtstaffid.TabIndex = 9;
            txtstaffid.Text = "`";
            // 
            // txtstaffname
            // 
            txtstaffname.Font = new Font("Kh Battambang", 14.25F);
            txtstaffname.Location = new Point(24, 252);
            txtstaffname.Margin = new Padding(3, 4, 3, 4);
            txtstaffname.Name = "txtstaffname";
            txtstaffname.Size = new Size(200, 43);
            txtstaffname.TabIndex = 10;
            // 
            // txtphone
            // 
            txtphone.Font = new Font("Kh Battambang", 14.25F);
            txtphone.Location = new Point(495, 129);
            txtphone.Margin = new Padding(3, 4, 3, 4);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(200, 43);
            txtphone.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 91);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 14;
            label1.Text = "Staff ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 214);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 15;
            label2.Text = "Staff Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(495, 91);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 16;
            label3.Text = "Phone";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(492, 214);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 17;
            label4.Text = "Hired Date";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(274, 91);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 18;
            label5.Text = "Gender";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 331);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1074, 419);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Kh Battambang", 14.25F);
            dateTimePicker1.Location = new Point(492, 252);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 43);
            dateTimePicker1.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(274, 209);
            label6.Name = "label6";
            label6.Size = new Size(80, 23);
            label6.TabIndex = 22;
            label6.Text = "Position";
            // 
            // txtpos
            // 
            txtpos.Font = new Font("Kh Battambang", 14.25F);
            txtpos.Location = new Point(274, 252);
            txtpos.Margin = new Padding(3, 4, 3, 4);
            txtpos.Name = "txtpos";
            txtpos.Size = new Size(200, 43);
            txtpos.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Kh Battambang", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(274, 129);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 42);
            comboBox1.TabIndex = 23;
            // 
            // btnadd
            // 
            btnadd.BackColor = SystemColors.ActiveBorder;
            btnadd.BackgroundImage = (Image)resources.GetObject("btnadd.BackgroundImage");
            btnadd.BackgroundImageLayout = ImageLayout.Zoom;
            btnadd.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(336, 758);
            btnadd.Margin = new Padding(3, 4, 3, 4);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(106, 47);
            btnadd.TabIndex = 24;
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click_1;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ActiveBorder;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(725, 63);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(336, 260);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 25;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(403, 21);
            label7.Name = "label7";
            label7.Size = new Size(333, 38);
            label7.TabIndex = 27;
            label7.Text = "Staff Information";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Kh Battambang", 14.25F);
            label8.Location = new Point(365, 810);
            label8.Name = "label8";
            label8.Size = new Size(55, 34);
            label8.TabIndex = 28;
            label8.Text = "Save";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Kh Battambang", 14.25F);
            label9.Location = new Point(495, 809);
            label9.Name = "label9";
            label9.Size = new Size(73, 34);
            label9.TabIndex = 29;
            label9.Text = "Update";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Kh Battambang", 14.25F);
            label10.Location = new Point(634, 810);
            label10.Name = "label10";
            label10.Size = new Size(46, 34);
            label10.TabIndex = 30;
            label10.Text = "Edit";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Kh Battambang", 14.25F);
            label11.Location = new Point(743, 810);
            label11.Name = "label11";
            label11.Size = new Size(82, 34);
            label11.TabIndex = 31;
            label11.Text = "Remove";
            // 
            // TranInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 852);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox6);
            Controls.Add(btnadd);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(txtpos);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtphone);
            Controls.Add(txtstaffname);
            Controls.Add(txtstaffid);
            Controls.Add(button5);
            Controls.Add(btndel);
            Controls.Add(btnedit);
            Controls.Add(btnup);
            Font = new Font("Kh Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TranInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "x";
            Load += TranInformation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnup;
        private Button btnedit;
        private Button btndel;
        private Button button5;
        private TextBox txtstaffid;
        private TextBox txtstaffname;
        private TextBox txtphone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox txtpos;
        private ComboBox comboBox1;
        private Button btnadd;
        private PictureBox pictureBox6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}