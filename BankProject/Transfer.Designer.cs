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
            dateTimePicker1 = new DateTimePicker();
            txtamount = new TextBox();
            label6 = new Label();
            txttacc = new TextBox();
            label1 = new Label();
            txtfacc = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Kh Battambang", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(9, 211);
            dateTimePicker1.Margin = new Padding(4, 7, 4, 7);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(347, 45);
            dateTimePicker1.TabIndex = 54;
            // 
            // txtamount
            // 
            txtamount.Font = new Font("Kh Battambang", 15.75F);
            txtamount.Location = new Point(364, 209);
            txtamount.Margin = new Padding(4, 7, 4, 7);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(347, 47);
            txtamount.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Kh Battambang", 14.25F);
            label6.Location = new Point(364, 173);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 34);
            label6.TabIndex = 52;
            label6.Text = "ចំនួនទឹកប្រាក់";
            // 
            // txttacc
            // 
            txttacc.Font = new Font("Kh Battambang", 15.75F);
            txttacc.Location = new Point(364, 121);
            txttacc.Margin = new Padding(4, 7, 4, 7);
            txttacc.Name = "txttacc";
            txttacc.Size = new Size(347, 47);
            txttacc.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Battambang", 14.25F);
            label1.Location = new Point(364, 84);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 34);
            label1.TabIndex = 50;
            label1.Text = "ទៅកាន់គណនី";
            // 
            // txtfacc
            // 
            txtfacc.Font = new Font("Kh Battambang", 15.75F);
            txtfacc.Location = new Point(9, 123);
            txtfacc.Margin = new Padding(4, 7, 4, 7);
            txtfacc.Name = "txtfacc";
            txtfacc.Size = new Size(347, 47);
            txtfacc.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Battambang", 14.25F);
            label2.Location = new Point(9, 86);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 34);
            label2.TabIndex = 48;
            label2.Text = "ពីគណនី";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 128, 255);
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Font = new Font("Kh Battambang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(9, 270);
            button2.Margin = new Padding(4, 7, 4, 7);
            button2.Name = "button2";
            button2.Size = new Size(155, 61);
            button2.TabIndex = 57;
            button2.Text = "ផ្ងើរប្រាក់";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.Font = new Font("Kh Battambang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Image = Properties.Resources.close2;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(13, 505);
            button5.Margin = new Padding(4, 7, 4, 7);
            button5.Name = "button5";
            button5.Size = new Size(151, 61);
            button5.TabIndex = 59;
            button5.Text = "ចាកចេញ";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(364, 264);
            pictureBox1.Margin = new Padding(4, 7, 4, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 302);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kh Muol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(275, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(169, 58);
            label3.TabIndex = 61;
            label3.Text = "ផ្ងើរប្រាក់";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kh Battambang", 14.25F);
            label4.Location = new Point(13, 177);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 34);
            label4.TabIndex = 62;
            label4.Text = "ថ្ងៃ-ខែ-ឆ្នាំ";
            // 
            // Transfer
            // 
            AutoScaleDimensions = new SizeF(10F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(722, 582);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button2);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private TextBox txtamount;
        private Label label6;
        private TextBox txttacc;
        private Label label1;
        private TextBox txtfacc;
        private Label label2;
        private Button button2;
        private Button button5;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
    }
}