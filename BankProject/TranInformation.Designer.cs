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
            btnup = new Button();
            btnedit = new Button();
            btndel = new Button();
            button5 = new Button();
            txtstaffid = new TextBox();
            txtstaffname = new TextBox();
            txtphone = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            txtpos = new TextBox();
            comboBox1 = new ComboBox();
            btnadd = new Button();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnup
            // 
            btnup.BackColor = Color.FromArgb(0, 192, 0);
            btnup.BackgroundImageLayout = ImageLayout.Zoom;
            btnup.Font = new Font("Kh Battambang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnup.ImageAlign = ContentAlignment.MiddleLeft;
            btnup.Location = new Point(150, 260);
            btnup.Margin = new Padding(4, 6, 4, 6);
            btnup.Name = "btnup";
            btnup.Size = new Size(147, 58);
            btnup.TabIndex = 1;
            btnup.Text = "កែទិន្ន័យ";
            btnup.UseVisualStyleBackColor = false;
            btnup.Click += btnadd_Click;
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.FromArgb(192, 192, 255);
            btnedit.BackgroundImageLayout = ImageLayout.None;
            btnedit.Font = new Font("Kh Battambang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnedit.ImageAlign = ContentAlignment.MiddleLeft;
            btnedit.Location = new Point(305, 260);
            btnedit.Margin = new Padding(4, 6, 4, 6);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(145, 58);
            btnedit.TabIndex = 2;
            btnedit.Text = "ចាប់ទិន្ន័យ";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // btndel
            // 
            btndel.BackColor = Color.Red;
            btndel.BackgroundImageLayout = ImageLayout.None;
            btndel.Font = new Font("Kh Battambang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndel.ImageAlign = ContentAlignment.MiddleLeft;
            btndel.Location = new Point(458, 260);
            btndel.Margin = new Padding(4, 6, 4, 6);
            btndel.Name = "btndel";
            btndel.Size = new Size(130, 58);
            btndel.TabIndex = 3;
            btndel.Text = "លុប";
            btndel.UseVisualStyleBackColor = false;
            btndel.Click += btndel_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.Font = new Font("Kh Battambang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(867, 256);
            button5.Margin = new Padding(4, 6, 4, 6);
            button5.Name = "button5";
            button5.Size = new Size(148, 58);
            button5.TabIndex = 8;
            button5.Text = "ចាកចេញ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // txtstaffid
            // 
            txtstaffid.Cursor = Cursors.No;
            txtstaffid.Font = new Font("Kh Battambang", 14.25F);
            txtstaffid.Location = new Point(12, 120);
            txtstaffid.Margin = new Padding(4, 6, 4, 6);
            txtstaffid.Name = "txtstaffid";
            txtstaffid.ReadOnly = true;
            txtstaffid.Size = new Size(284, 43);
            txtstaffid.TabIndex = 9;
            // 
            // txtstaffname
            // 
            txtstaffname.Font = new Font("Kh Battambang", 14.25F);
            txtstaffname.Location = new Point(304, 119);
            txtstaffname.Margin = new Padding(4, 6, 4, 6);
            txtstaffname.Name = "txtstaffname";
            txtstaffname.Size = new Size(347, 43);
            txtstaffname.TabIndex = 10;
            // 
            // txtphone
            // 
            txtphone.Font = new Font("Kh Battambang", 14.25F);
            txtphone.Location = new Point(12, 205);
            txtphone.Margin = new Padding(4, 6, 4, 6);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(284, 43);
            txtphone.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Battambang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 38);
            label1.TabIndex = 14;
            label1.Text = "បុគ្គលិក-កូដ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 344);
            dataGridView1.Margin = new Padding(4, 6, 4, 6);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1003, 424);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Kh Battambang", 14.25F);
            dateTimePicker1.Location = new Point(659, 205);
            dateTimePicker1.Margin = new Padding(4, 6, 4, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(356, 43);
            dateTimePicker1.TabIndex = 20;
            // 
            // txtpos
            // 
            txtpos.Font = new Font("Kh Battambang", 14.25F);
            txtpos.Location = new Point(304, 204);
            txtpos.Margin = new Padding(4, 6, 4, 6);
            txtpos.Name = "txtpos";
            txtpos.Size = new Size(347, 43);
            txtpos.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Kh Battambang", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ប្រុស", "ស្រី" });
            comboBox1.Location = new Point(659, 119);
            comboBox1.Margin = new Padding(4, 6, 4, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(356, 42);
            comboBox1.TabIndex = 23;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.FromArgb(128, 128, 255);
            btnadd.BackgroundImageLayout = ImageLayout.None;
            btnadd.Font = new Font("Kh Battambang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadd.ImageAlign = ContentAlignment.BottomRight;
            btnadd.Location = new Point(12, 260);
            btnadd.Margin = new Padding(4, 6, 4, 6);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(130, 58);
            btnadd.TabIndex = 24;
            btnadd.Text = "រក្សាទុក";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Moul", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(374, 9);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(277, 58);
            label7.TabIndex = 27;
            label7.Text = "ព័ត៏មានបុគ្គលិក";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icons8_clear_50;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(595, 261);
            button1.Name = "button1";
            button1.Size = new Size(130, 58);
            button1.TabIndex = 33;
            button1.Text = "សម្អាត";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Kh Battambang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(304, 82);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(134, 38);
            label8.TabIndex = 34;
            label8.Text = "ឈ្មោះបុគ្គលិក";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Battambang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(660, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 38);
            label2.TabIndex = 35;
            label2.Text = "ភេទ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kh Battambang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 167);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 38);
            label5.TabIndex = 36;
            label5.Text = "លេខទូរស័ព្ទ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kh Battambang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(304, 167);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 38);
            label3.TabIndex = 37;
            label3.Text = "មុខដំណែង";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Kh Battambang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(661, 164);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(124, 38);
            label6.TabIndex = 38;
            label6.Text = "ថ្ងៃចូលធ្វើការ";
            // 
            // TranInformation
            // 
            AutoScaleDimensions = new SizeF(10F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1034, 782);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(btnadd);
            Controls.Add(comboBox1);
            Controls.Add(txtpos);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(txtphone);
            Controls.Add(txtstaffname);
            Controls.Add(txtstaffid);
            Controls.Add(button5);
            Controls.Add(btndel);
            Controls.Add(btnedit);
            Controls.Add(btnup);
            Font = new Font("Kh Battambang", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "TranInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "x";
            Load += TranInformation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtpos;
        private ComboBox comboBox1;
        private Button btnadd;
        private Label label7;
        private Button button1;
        private Label label8;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label6;
    }
}