namespace BankProject
{
    partial class DepositReport
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            lblAccNo = new Label();
            lblbl = new Label();
            lblDeposit = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Moul", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 58);
            label1.TabIndex = 0;
            label1.Text = "វិក័យបត្រ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 4);
            label2.Name = "label2";
            label2.Size = new Size(124, 38);
            label2.TabIndex = 1;
            label2.Text = "ទឹកប្រាក់ដាក់";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 4);
            label3.Name = "label3";
            label3.Size = new Size(131, 38);
            label3.TabIndex = 2;
            label3.Text = "ទឹកប្រាក់សរុប";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 4);
            label5.Name = "label5";
            label5.Size = new Size(117, 38);
            label5.TabIndex = 4;
            label5.Text = "លេខគណនី";
            // 
            // lblAccNo
            // 
            lblAccNo.AutoSize = true;
            lblAccNo.Location = new Point(41, 143);
            lblAccNo.Name = "lblAccNo";
            lblAccNo.Size = new Size(117, 38);
            lblAccNo.TabIndex = 8;
            lblAccNo.Text = "លេខគណនី";
            // 
            // lblbl
            // 
            lblbl.AutoSize = true;
            lblbl.Location = new Point(361, 143);
            lblbl.Name = "lblbl";
            lblbl.Size = new Size(91, 38);
            lblbl.TabIndex = 6;
            lblbl.Text = "Balance";
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Location = new Point(183, 143);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(174, 38);
            lblDeposit.TabIndex = 5;
            lblDeposit.Text = "Deposite Amount";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(14, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 46);
            panel1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Moul", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(113, 534);
            label6.Name = "label6";
            label6.Size = new Size(115, 38);
            label6.TabIndex = 10;
            label6.Text = "_អរគុណ_";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 496);
            label7.Name = "label7";
            label7.Size = new Size(274, 38);
            label7.TabIndex = 5;
            label7.Text = "ប្រតិបត្តិការទទួលបានជោគជ័យ";
            // 
            // button1
            // 
            button1.Location = new Point(392, 522);
            button1.Name = "button1";
            button1.Size = new Size(124, 49);
            button1.TabIndex = 11;
            button1.Text = "យល់ព្រម";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DepositReport
            // 
            AutoScaleDimensions = new SizeF(12F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 582);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(lblAccNo);
            Controls.Add(lblbl);
            Controls.Add(lblDeposit);
            Controls.Add(label1);
            Font = new Font("Kh Battambang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 8, 5, 8);
            Name = "DepositReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DepositReport";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label lblAccNo;
        private Label lblbl;
        private Label lblDeposit;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}