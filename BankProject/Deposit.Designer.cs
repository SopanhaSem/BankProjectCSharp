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
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(128, 188);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 43;
            label5.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(122, 212);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 23);
            dateTimePicker1.TabIndex = 42;
            // 
            // txtdeposit
            // 
            txtdeposit.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdeposit.Location = new Point(401, 212);
            txtdeposit.Multiline = true;
            txtdeposit.Name = "txtdeposit";
            txtdeposit.Size = new Size(244, 33);
            txtdeposit.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(401, 188);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 40;
            label4.Text = "Deposit";
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.FromArgb(192, 255, 192);
            btnsearch.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsearch.Location = new Point(141, 267);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(115, 40);
            btnsearch.TabIndex = 36;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsave_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(12, 12);
            button5.Name = "button5";
            button5.Size = new Size(80, 40);
            button5.TabIndex = 35;
            button5.Text = "←";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(334, 46);
            label3.Name = "label3";
            label3.Size = new Size(118, 36);
            label3.TabIndex = 34;
            label3.Text = "Deposit";
            // 
            // txtamount
            // 
            txtamount.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtamount.Location = new Point(401, 143);
            txtamount.Multiline = true;
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(244, 33);
            txtamount.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(401, 119);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 32;
            label1.Text = "Balance";
            // 
            // txtaccno
            // 
            txtaccno.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtaccno.Location = new Point(122, 143);
            txtaccno.Multiline = true;
            txtaccno.Name = "txtaccno";
            txtaccno.Size = new Size(244, 33);
            txtaccno.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 119);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(139, 21);
            label2.TabIndex = 30;
            label2.Text = "Account Number";
            // 
            // btns
            // 
            btns.BackColor = Color.Blue;
            btns.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btns.Location = new Point(262, 267);
            btns.Name = "btns";
            btns.Size = new Size(115, 40);
            btns.TabIndex = 44;
            btns.Text = "Deposit";
            btns.UseVisualStyleBackColor = false;
            btns.Click += btns_Click;
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
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
            Name = "Deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
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
    }
}