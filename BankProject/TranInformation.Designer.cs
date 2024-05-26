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
            label7 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnup
            // 
            btnup.BackColor = Color.FromArgb(0, 192, 0);
            btnup.BackgroundImageLayout = ImageLayout.Zoom;
            btnup.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnup.Image = (Image)resources.GetObject("btnup.Image");
            btnup.ImageAlign = ContentAlignment.MiddleLeft;
            btnup.Location = new Point(208, 260);
            btnup.Margin = new Padding(4, 6, 4, 6);
            btnup.Name = "btnup";
            btnup.Size = new Size(130, 54);
            btnup.TabIndex = 1;
            btnup.Text = "Update";
            btnup.TextAlign = ContentAlignment.MiddleRight;
            btnup.UseVisualStyleBackColor = false;
            btnup.Click += btnadd_Click;
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.FromArgb(192, 192, 255);
            btnedit.BackgroundImageLayout = ImageLayout.None;
            btnedit.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnedit.Image = Properties.Resources.edit;
            btnedit.ImageAlign = ContentAlignment.MiddleLeft;
            btnedit.Location = new Point(361, 260);
            btnedit.Margin = new Padding(4, 6, 4, 6);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(130, 54);
            btnedit.TabIndex = 2;
            btnedit.Text = "Edit";
            btnedit.TextAlign = ContentAlignment.MiddleRight;
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // btndel
            // 
            btndel.BackColor = Color.Red;
            btndel.BackgroundImage = (Image)resources.GetObject("btndel.BackgroundImage");
            btndel.BackgroundImageLayout = ImageLayout.None;
            btndel.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndel.ImageAlign = ContentAlignment.MiddleLeft;
            btndel.Location = new Point(518, 260);
            btndel.Margin = new Padding(4, 6, 4, 6);
            btndel.Name = "btndel";
            btndel.Size = new Size(130, 54);
            btndel.TabIndex = 3;
            btndel.Text = "Remove";
            btndel.TextAlign = ContentAlignment.MiddleRight;
            btndel.UseVisualStyleBackColor = false;
            btndel.Click += btndel_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Image = Properties.Resources.close3;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(13, 7);
            button5.Margin = new Padding(4, 6, 4, 6);
            button5.Name = "button5";
            button5.Size = new Size(137, 63);
            button5.TabIndex = 8;
            button5.Text = "Close";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // txtstaffid
            // 
            txtstaffid.Cursor = Cursors.No;
            txtstaffid.Font = new Font("Kh Battambang", 14.25F);
            txtstaffid.Location = new Point(53, 116);
            txtstaffid.Margin = new Padding(4, 6, 4, 6);
            txtstaffid.Name = "txtstaffid";
            txtstaffid.ReadOnly = true;
            txtstaffid.Size = new Size(284, 43);
            txtstaffid.TabIndex = 9;
            // 
            // txtstaffname
            // 
            txtstaffname.Font = new Font("Kh Battambang", 14.25F);
            txtstaffname.Location = new Point(397, 116);
            txtstaffname.Margin = new Padding(4, 6, 4, 6);
            txtstaffname.Name = "txtstaffname";
            txtstaffname.Size = new Size(284, 43);
            txtstaffname.TabIndex = 10;
            // 
            // txtphone
            // 
            txtphone.Font = new Font("Kh Battambang", 14.25F);
            txtphone.Location = new Point(53, 201);
            txtphone.Margin = new Padding(4, 6, 4, 6);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(284, 43);
            txtphone.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 87);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 14;
            label1.Text = "Staff ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(397, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 15;
            label2.Text = "Staff Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 180);
            label3.Margin = new Padding(4, 0, 4, 0);
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
            label4.Location = new Point(772, 175);
            label4.Margin = new Padding(4, 0, 4, 0);
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
            label5.Location = new Point(772, 87);
            label5.Margin = new Padding(4, 0, 4, 0);
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
            dataGridView1.Location = new Point(53, 340);
            dataGridView1.Margin = new Padding(4, 6, 4, 6);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1003, 387);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Kh Battambang", 14.25F);
            dateTimePicker1.Location = new Point(772, 197);
            dateTimePicker1.Margin = new Padding(4, 6, 4, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 43);
            dateTimePicker1.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(397, 172);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(80, 23);
            label6.TabIndex = 22;
            label6.Text = "Position";
            // 
            // txtpos
            // 
            txtpos.Font = new Font("Kh Battambang", 14.25F);
            txtpos.Location = new Point(397, 201);
            txtpos.Margin = new Padding(4, 6, 4, 6);
            txtpos.Name = "txtpos";
            txtpos.Size = new Size(284, 43);
            txtpos.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Kh Battambang", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(772, 116);
            comboBox1.Margin = new Padding(4, 6, 4, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(284, 42);
            comboBox1.TabIndex = 23;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.FromArgb(128, 128, 255);
            btnadd.BackgroundImage = (Image)resources.GetObject("btnadd.BackgroundImage");
            btnadd.BackgroundImageLayout = ImageLayout.None;
            btnadd.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(53, 260);
            btnadd.Margin = new Padding(4, 6, 4, 6);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(130, 54);
            btnadd.TabIndex = 24;
            btnadd.Text = "Save";
            btnadd.TextAlign = ContentAlignment.MiddleRight;
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Kh Battambang", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(89, 7);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(273, 58);
            label7.TabIndex = 27;
            label7.Text = "Staff Information";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(319, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 68);
            panel1.TabIndex = 32;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icons8_clear_50;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(655, 260);
            button1.Name = "button1";
            button1.Size = new Size(130, 54);
            button1.TabIndex = 33;
            button1.Text = "Clear";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // TranInformation
            // 
            AutoScaleDimensions = new SizeF(10F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 743);
            Controls.Add(button1);
            Controls.Add(panel1);
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
            Font = new Font("Kh Battambang", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "TranInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "x";
            Load += TranInformation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label7;
        private Panel panel1;
        private Button button1;
    }
}