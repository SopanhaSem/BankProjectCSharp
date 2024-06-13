namespace BankProject
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            dateTimePicker1 = new DateTimePicker();
            txtdeposit = new TextBox();
            btnsearch = new Button();
            button5 = new Button();
            txtamount = new TextBox();
            txtaccno = new TextBox();
            btns = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Kh Battambang", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(17, 216);
            dateTimePicker1.Margin = new Padding(4, 7, 4, 7);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(347, 43);
            dateTimePicker1.TabIndex = 42;
            // 
            // txtdeposit
            // 
            txtdeposit.Font = new Font("Kh Battambang", 14.25F);
            txtdeposit.Location = new Point(372, 219);
            txtdeposit.Margin = new Padding(4, 7, 4, 7);
            txtdeposit.Name = "txtdeposit";
            txtdeposit.Size = new Size(347, 43);
            txtdeposit.TabIndex = 41;
            // 
            // btnsearch
            // 
            btnsearch.BackColor = SystemColors.Control;
            btnsearch.BackgroundImage = (Image)resources.GetObject("btnsearch.BackgroundImage");
            btnsearch.BackgroundImageLayout = ImageLayout.None;
            btnsearch.Font = new Font("Kh Battambang", 15.75F);
            btnsearch.Location = new Point(17, 273);
            btnsearch.Margin = new Padding(4, 7, 4, 7);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(144, 54);
            btnsearch.TabIndex = 36;
            btnsearch.Text = "ស្វែងរក";
            btnsearch.TextAlign = ContentAlignment.MiddleRight;
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsave_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.Font = new Font("Kh Battambang", 15.75F);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(17, 509);
            button5.Margin = new Padding(4, 7, 4, 7);
            button5.Name = "button5";
            button5.Size = new Size(151, 58);
            button5.TabIndex = 35;
            button5.Text = "ចាកចេញ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // txtamount
            // 
            txtamount.Font = new Font("Kh Battambang", 14.25F);
            txtamount.Location = new Point(372, 124);
            txtamount.Margin = new Padding(4, 7, 4, 7);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(347, 43);
            txtamount.TabIndex = 33;
            txtamount.TextChanged += txtamount_TextChanged;
            // 
            // txtaccno
            // 
            txtaccno.Font = new Font("Kh Battambang", 14.25F);
            txtaccno.Location = new Point(17, 124);
            txtaccno.Margin = new Padding(4, 7, 4, 7);
            txtaccno.Name = "txtaccno";
            txtaccno.Size = new Size(347, 43);
            txtaccno.TabIndex = 31;
            // 
            // btns
            // 
            btns.BackColor = Color.FromArgb(128, 128, 255);
            btns.BackgroundImageLayout = ImageLayout.None;
            btns.Font = new Font("Kh Battambang", 15.75F);
            btns.Location = new Point(164, 273);
            btns.Margin = new Padding(4, 7, 4, 7);
            btns.Name = "btns";
            btns.Size = new Size(167, 54);
            btns.TabIndex = 44;
            btns.Text = "ដាក់ប្រាក់";
            btns.UseVisualStyleBackColor = false;
            btns.Click += btns_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(372, 273);
            pictureBox1.Margin = new Padding(4, 7, 4, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kh Muol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(260, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(181, 58);
            label3.TabIndex = 46;
            label3.Text = "ដាក់ប្រាក់";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Kh Battambang", 14.25F);
            label6.Location = new Point(17, 83);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 34);
            label6.TabIndex = 47;
            label6.Text = "លេខគណនី";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Battambang", 14.25F);
            label2.Location = new Point(372, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 34);
            label2.TabIndex = 48;
            label2.Text = "ចំនួនទឹកប្រាក់";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Battambang", 14.25F);
            label1.Location = new Point(17, 178);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 34);
            label1.TabIndex = 49;
            label1.Text = "ថ្ងៃ-ខែ-ឆ្នាំ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kh Battambang", 14.25F);
            label5.Location = new Point(372, 178);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(248, 34);
            label5.TabIndex = 50;
            label5.Text = "ចំនួនទឹកប្រាក់់សម្រាប់ដាក់ប្រាក់";
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(10F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(734, 583);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btns);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtdeposit);
            Controls.Add(btnsearch);
            Controls.Add(button5);
            Controls.Add(txtamount);
            Controls.Add(txtaccno);
            Font = new Font("Kh Battambang", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 7, 4, 7);
            Name = "Deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private TextBox txtdeposit;
        private Button btnsearch;
        private Button button5;
        private TextBox txtamount;
        private TextBox txtaccno;
        private Button btns;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label6;
        private Label label2;
        private Label label1;
        private Label label5;
    }
}