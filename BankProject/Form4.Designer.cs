namespace BankProject
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            txtusername = new TextBox();
            label2 = new Label();
            txtbalance = new TextBox();
            label1 = new Label();
            label3 = new Label();
            button5 = new Button();
            button1 = new Button();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtwithdraw = new TextBox();
            label6 = new Label();
            btnsearch = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Kh Battambang", 14.25F);
            txtusername.Location = new Point(167, 235);
            txtusername.Margin = new Padding(4, 7, 4, 7);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(347, 43);
            txtusername.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Battambang", 14.25F);
            label2.Location = new Point(171, 200);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 34);
            label2.TabIndex = 6;
            label2.Text = "Account Number";
            // 
            // txtbalance
            // 
            txtbalance.Font = new Font("Kh Battambang", 14.25F);
            txtbalance.Location = new Point(543, 235);
            txtbalance.Margin = new Padding(4, 7, 4, 7);
            txtbalance.Name = "txtbalance";
            txtbalance.Size = new Size(347, 43);
            txtbalance.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Battambang", 14.25F);
            label1.Location = new Point(543, 200);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 34);
            label1.TabIndex = 8;
            label1.Text = "Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kh Battambang", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 22);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(167, 58);
            label3.TabIndex = 10;
            label3.Text = "Withdraw";
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Image = Properties.Resources.close1;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(17, 27);
            button5.Margin = new Padding(4, 7, 4, 7);
            button5.Name = "button5";
            button5.Size = new Size(136, 56);
            button5.TabIndex = 12;
            button5.Text = "Close";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(316, 436);
            button1.Margin = new Padding(4, 7, 4, 7);
            button1.Name = "button1";
            button1.Size = new Size(198, 62);
            button1.TabIndex = 25;
            button1.Text = "Withdraw";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kh Battambang", 14.25F);
            label5.Location = new Point(167, 327);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 34);
            label5.TabIndex = 47;
            label5.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Kh Battambang", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Kh Battambang", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(167, 358);
            dateTimePicker1.Margin = new Padding(4, 7, 4, 7);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(347, 43);
            dateTimePicker1.TabIndex = 46;
            // 
            // txtwithdraw
            // 
            txtwithdraw.Font = new Font("Kh Battambang", 14.25F);
            txtwithdraw.Location = new Point(543, 358);
            txtwithdraw.Margin = new Padding(4, 7, 4, 7);
            txtwithdraw.Name = "txtwithdraw";
            txtwithdraw.Size = new Size(347, 43);
            txtwithdraw.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Kh Battambang", 14.25F);
            label6.Location = new Point(532, 327);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 34);
            label6.TabIndex = 44;
            label6.Text = "Withdraw";
            // 
            // btnsearch
            // 
            btnsearch.BackColor = SystemColors.Control;
            btnsearch.BackgroundImage = (Image)resources.GetObject("btnsearch.BackgroundImage");
            btnsearch.BackgroundImageLayout = ImageLayout.None;
            btnsearch.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsearch.Location = new Point(167, 436);
            btnsearch.Margin = new Padding(4, 7, 4, 7);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(141, 62);
            btnsearch.TabIndex = 48;
            btnsearch.Text = "Search";
            btnsearch.TextAlign = ContentAlignment.MiddleRight;
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(543, 448);
            pictureBox1.Margin = new Padding(4, 7, 4, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(453, 392);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(413, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 103);
            panel1.TabIndex = 50;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1056, 856);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnsearch);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtwithdraw);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(txtbalance);
            Controls.Add(label1);
            Controls.Add(txtusername);
            Controls.Add(label2);
            Font = new Font("Kh Battambang", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 7, 4, 7);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtusername;
        private Label label2;
        private TextBox txtbalance;
        private Label label1;
        private Label label3;
        private Button button5;
        private Button button1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox txtwithdraw;
        private Label label6;
        private Button btnsearch;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}