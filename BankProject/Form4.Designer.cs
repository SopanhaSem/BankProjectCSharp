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
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(160, 134);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(244, 33);
            txtusername.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(160, 110);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 6;
            label2.Text = "Account Number";
            // 
            // txtbalance
            // 
            txtbalance.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbalance.Location = new Point(423, 134);
            txtbalance.Multiline = true;
            txtbalance.Name = "txtbalance";
            txtbalance.Size = new Size(244, 33);
            txtbalance.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(423, 110);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 8;
            label1.Text = "Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(338, 50);
            label3.Name = "label3";
            label3.Size = new Size(155, 36);
            label3.TabIndex = 10;
            label3.Text = "Withdraw";
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(12, 12);
            button5.Name = "button5";
            button5.Size = new Size(80, 40);
            button5.TabIndex = 12;
            button5.Text = "←";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(270, 251);
            button1.Name = "button1";
            button1.Size = new Size(115, 40);
            button1.TabIndex = 25;
            button1.Text = "Withdraw";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(160, 178);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 47;
            label5.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(160, 203);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 23);
            dateTimePicker1.TabIndex = 46;
            // 
            // txtwithdraw
            // 
            txtwithdraw.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtwithdraw.Location = new Point(423, 202);
            txtwithdraw.Multiline = true;
            txtwithdraw.Name = "txtwithdraw";
            txtwithdraw.Size = new Size(244, 33);
            txtwithdraw.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(423, 178);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 44;
            label6.Text = "Withdraw";
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.FromArgb(192, 255, 192);
            btnsearch.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsearch.Location = new Point(149, 251);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(115, 40);
            btnsearch.TabIndex = 48;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsearch);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtwithdraw);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(txtbalance);
            Controls.Add(label1);
            Controls.Add(txtusername);
            Controls.Add(label2);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
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
    }
}