﻿namespace BankProject
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
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtdeposit = new TextBox();
            label4 = new Label();
            btnsearch = new Button();
            button5 = new Button();
            label3 = new Label();
            txtamount = new TextBox();
            label1 = new Label();
            txtaccno = new TextBox();
            label2 = new Label();
            btns = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kh Battambang", 14.25F);
            label5.Location = new Point(160, 292);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 34);
            label5.TabIndex = 43;
            label5.Text = "Date";
            label5.Click += label5_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Kh Battambang", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(160, 333);
            dateTimePicker1.Margin = new Padding(4, 7, 4, 7);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(347, 43);
            dateTimePicker1.TabIndex = 42;
            // 
            // txtdeposit
            // 
            txtdeposit.Font = new Font("Kh Battambang", 14.25F);
            txtdeposit.Location = new Point(559, 333);
            txtdeposit.Margin = new Padding(4, 7, 4, 7);
            txtdeposit.Name = "txtdeposit";
            txtdeposit.Size = new Size(347, 43);
            txtdeposit.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kh Battambang", 14.25F);
            label4.Location = new Point(559, 292);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 34);
            label4.TabIndex = 40;
            label4.Text = "Deposit";
            // 
            // btnsearch
            // 
            btnsearch.BackColor = SystemColors.Control;
            btnsearch.BackgroundImage = (Image)resources.GetObject("btnsearch.BackgroundImage");
            btnsearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnsearch.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsearch.Location = new Point(182, 390);
            btnsearch.Margin = new Padding(4, 7, 4, 7);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(137, 54);
            btnsearch.TabIndex = 36;
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsave_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(17, 27);
            button5.Margin = new Padding(4, 7, 4, 7);
            button5.Name = "button5";
            button5.Size = new Size(114, 47);
            button5.TabIndex = 35;
            button5.Text = "←";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(449, 94);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 38);
            label3.TabIndex = 34;
            label3.Text = "Deposit";
            // 
            // txtamount
            // 
            txtamount.Font = new Font("Kh Battambang", 14.25F);
            txtamount.Location = new Point(559, 219);
            txtamount.Margin = new Padding(4, 7, 4, 7);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(347, 43);
            txtamount.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Battambang", 14.25F);
            label1.Location = new Point(559, 178);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 34);
            label1.TabIndex = 32;
            label1.Text = "Balance";
            // 
            // txtaccno
            // 
            txtaccno.Font = new Font("Kh Battambang", 14.25F);
            txtaccno.Location = new Point(160, 219);
            txtaccno.Margin = new Padding(4, 7, 4, 7);
            txtaccno.Name = "txtaccno";
            txtaccno.Size = new Size(347, 43);
            txtaccno.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Battambang", 14.25F);
            label2.Location = new Point(160, 178);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(154, 34);
            label2.TabIndex = 30;
            label2.Text = "Account Number";
            // 
            // btns
            // 
            btns.BackColor = SystemColors.Control;
            btns.BackgroundImage = (Image)resources.GetObject("btns.BackgroundImage");
            btns.BackgroundImageLayout = ImageLayout.Zoom;
            btns.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btns.Location = new Point(355, 390);
            btns.Margin = new Padding(4, 7, 4, 7);
            btns.Name = "btns";
            btns.Size = new Size(137, 54);
            btns.TabIndex = 44;
            btns.UseVisualStyleBackColor = false;
            btns.Click += btns_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(559, 390);
            pictureBox1.Margin = new Padding(4, 7, 4, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 392);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(381, 451);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(75, 23);
            label9.TabIndex = 47;
            label9.Text = "Deposit";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(216, 451);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(65, 23);
            label8.TabIndex = 46;
            label8.Text = "Search";
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(10F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1056, 856);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(btns);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtdeposit);
            Controls.Add(label4);
            Controls.Add(btnsearch);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(txtamount);
            Controls.Add(label1);
            Controls.Add(txtaccno);
            Controls.Add(label2);
            Font = new Font("Kh Battambang", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 7, 4, 7);
            Name = "Deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox txtdeposit;
        private Label label4;
        private Button btnsearch;
        private Button button5;
        private Label label3;
        private TextBox txtamount;
        private Label label1;
        private TextBox txtaccno;
        private Label label2;
        private Button btns;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label8;
    }
}