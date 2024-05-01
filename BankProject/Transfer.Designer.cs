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
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(154, 171);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 55;
            label5.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(154, 196);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 23);
            dateTimePicker1.TabIndex = 54;
            // 
            // txtamount
            // 
            txtamount.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtamount.Location = new Point(417, 195);
            txtamount.Multiline = true;
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(244, 33);
            txtamount.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(417, 171);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 52;
            label6.Text = "Amount";
            // 
            // txttacc
            // 
            txttacc.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttacc.Location = new Point(417, 127);
            txttacc.Multiline = true;
            txttacc.Name = "txttacc";
            txttacc.Size = new Size(244, 33);
            txttacc.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(417, 103);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 50;
            label1.Text = "To Account";
            // 
            // txtfacc
            // 
            txtfacc.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtfacc.Location = new Point(154, 127);
            txtfacc.Multiline = true;
            txtfacc.Name = "txtfacc";
            txtfacc.Size = new Size(244, 33);
            txtfacc.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(154, 103);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 48;
            label2.Text = "From Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(330, 22);
            label3.Name = "label3";
            label3.Size = new Size(122, 36);
            label3.TabIndex = 56;
            label3.Text = "Tranfer";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(154, 245);
            button2.Name = "button2";
            button2.Size = new Size(136, 40);
            button2.TabIndex = 57;
            button2.Text = "Transfer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(23, 21);
            button5.Name = "button5";
            button5.Size = new Size(80, 40);
            button5.TabIndex = 59;
            button5.Text = "←";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Transfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtamount);
            Controls.Add(label6);
            Controls.Add(txttacc);
            Controls.Add(label1);
            Controls.Add(txtfacc);
            Controls.Add(label2);
            Name = "Transfer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transfer";
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
    }
}