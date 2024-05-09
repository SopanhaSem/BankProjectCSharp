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
            pictureBox1 = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnup
            // 
            btnup.BackColor = SystemColors.ActiveBorder;
            btnup.BackgroundImage = (Image)resources.GetObject("btnup.BackgroundImage");
            btnup.BackgroundImageLayout = ImageLayout.Zoom;
            btnup.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnup.Location = new Point(244, 564);
            btnup.Name = "btnup";
            btnup.Size = new Size(108, 42);
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
            btnedit.Location = new Point(371, 564);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(111, 42);
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
            btndel.Location = new Point(500, 564);
            btndel.Name = "btndel";
            btndel.Size = new Size(108, 42);
            btndel.TabIndex = 3;
            btndel.UseVisualStyleBackColor = false;
            btndel.Click += btndel_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(12, 12);
            button5.Name = "button5";
            button5.Size = new Size(80, 40);
            button5.TabIndex = 8;
            button5.Text = "←";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // txtstaffid
            // 
            txtstaffid.Font = new Font("Times New Roman", 15.75F);
            txtstaffid.Location = new Point(32, 126);
            txtstaffid.Name = "txtstaffid";
            txtstaffid.Size = new Size(200, 32);
            txtstaffid.TabIndex = 9;
            txtstaffid.Text = "`";
            // 
            // txtstaffname
            // 
            txtstaffname.Font = new Font("Times New Roman", 15.75F);
            txtstaffname.Location = new Point(32, 210);
            txtstaffname.Name = "txtstaffname";
            txtstaffname.Size = new Size(200, 32);
            txtstaffname.TabIndex = 10;
            // 
            // txtphone
            // 
            txtphone.Font = new Font("Times New Roman", 15.75F);
            txtphone.Location = new Point(503, 126);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(200, 32);
            txtphone.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 100);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 14;
            label1.Text = "Staff ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 184);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 15;
            label2.Text = "Staff Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(503, 100);
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
            label4.Location = new Point(500, 184);
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
            label5.Location = new Point(282, 100);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 18;
            label5.Text = "Gender";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 270);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(691, 286);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Times New Roman", 15.75F);
            dateTimePicker1.Location = new Point(500, 210);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 32);
            dateTimePicker1.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(282, 181);
            label6.Name = "label6";
            label6.Size = new Size(80, 23);
            label6.TabIndex = 22;
            label6.Text = "Position";
            // 
            // txtpos
            // 
            txtpos.Font = new Font("Times New Roman", 15.75F);
            txtpos.Location = new Point(282, 210);
            txtpos.Name = "txtpos";
            txtpos.Size = new Size(200, 32);
            txtpos.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 15.75F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(282, 126);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 31);
            comboBox1.TabIndex = 23;
            // 
            // btnadd
            // 
            btnadd.BackColor = SystemColors.ActiveBorder;
            btnadd.BackgroundImage = (Image)resources.GetObject("btnadd.BackgroundImage");
            btnadd.BackgroundImageLayout = ImageLayout.Zoom;
            btnadd.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(108, 564);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(109, 42);
            btnadd.TabIndex = 24;
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click_1;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ActiveBorder;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(726, 261);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(378, 295);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 25;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(761, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(403, 14);
            label7.Name = "label7";
            label7.Size = new Size(333, 38);
            label7.TabIndex = 27;
            label7.Text = "Staff Information";
            // 
            // TranInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 663);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
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
            Name = "TranInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "x";
            Load += TranInformation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label label7;
    }
}