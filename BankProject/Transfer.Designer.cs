namespace BankProject
{
    partial class Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtamount = new TextBox();
            label6 = new Label();
            txttacc = new TextBox();
            label1 = new Label();
            txtfacc = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kh Battambang", 14.25F);
            label5.Location = new Point(210, 321);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 34);
            label5.TabIndex = 55;
            label5.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Kh Battambang", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(210, 357);
            dateTimePicker1.Margin = new Padding(4, 7, 4, 7);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(347, 45);
            dateTimePicker1.TabIndex = 54;
            // 
            // txtamount
            // 
            txtamount.Font = new Font("Kh Battambang", 15.75F);
            txtamount.Location = new Point(586, 357);
            txtamount.Margin = new Padding(4, 7, 4, 7);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(347, 47);
            txtamount.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Kh Battambang", 14.25F);
            label6.Location = new Point(586, 321);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 34);
            label6.TabIndex = 52;
            label6.Text = "Amount";
            // 
            // txttacc
            // 
            txttacc.Font = new Font("Kh Battambang", 15.75F);
            txttacc.Location = new Point(586, 259);
            txttacc.Margin = new Padding(4, 7, 4, 7);
            txttacc.Name = "txttacc";
            txttacc.Size = new Size(347, 47);
            txttacc.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Battambang", 14.25F);
            label1.Location = new Point(586, 222);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 34);
            label1.TabIndex = 50;
            label1.Text = "To Account";
            // 
            // txtfacc
            // 
            txtfacc.Font = new Font("Kh Battambang", 15.75F);
            txtfacc.Location = new Point(210, 259);
            txtfacc.Margin = new Padding(4, 7, 4, 7);
            txtfacc.Name = "txtfacc";
            txtfacc.Size = new Size(347, 47);
            txtfacc.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Battambang", 14.25F);
            label2.Location = new Point(210, 222);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 34);
            label2.TabIndex = 48;
            label2.Text = "From Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kh Battambang", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 24);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 58);
            label3.TabIndex = 56;
            label3.Text = "Tranfer";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 128, 255);
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(210, 408);
            button2.Margin = new Padding(4, 7, 4, 7);
            button2.Name = "button2";
            button2.Size = new Size(176, 61);
            button2.TabIndex = 57;
            button2.Text = "Transfer";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Image = Properties.Resources.close2;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(13, 16);
            button5.Margin = new Padding(4, 7, 4, 7);
            button5.Name = "button5";
            button5.Size = new Size(134, 60);
            button5.TabIndex = 59;
            button5.Text = "Close";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(586, 420);
            pictureBox1.Margin = new Padding(4, 7, 4, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 392);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(465, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 103);
            panel1.TabIndex = 63;
            // 
            // Transfer
            // 
            AutoScaleDimensions = new SizeF(10F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1143, 897);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtamount);
            Controls.Add(label6);
            Controls.Add(txttacc);
            Controls.Add(label1);
            Controls.Add(txtfacc);
            Controls.Add(label2);
            Font = new Font("Kh Battambang", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 7, 4, 7);
            Name = "Transfer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transfer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox txtamount;
        private Label label6;
        private TextBox txttacc;
        private Label label1;
        private TextBox txtfacc;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button5;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}