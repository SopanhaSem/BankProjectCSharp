namespace BankProject
{
    partial class WithDrawReport
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
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblAccNo = new Label();
            lblbl = new Label();
            lblDeposit = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Kh Battambang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(372, 483);
            button1.Name = "button1";
            button1.Size = new Size(124, 49);
            button1.TabIndex = 19;
            button1.Text = "យល់ព្រម";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Kh Battambang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 471);
            label7.Name = "label7";
            label7.Size = new Size(274, 38);
            label7.TabIndex = 13;
            label7.Text = "ប្រតិបត្តិការទទួលបានជោគជ័យ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Moul", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(105, 509);
            label6.Name = "label6";
            label6.Size = new Size(115, 38);
            label6.TabIndex = 18;
            label6.Text = "_អរគុណ_";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(4, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 46);
            panel1.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kh Battambang", 15.75F);
            label5.Location = new Point(35, 4);
            label5.Name = "label5";
            label5.Size = new Size(117, 38);
            label5.TabIndex = 4;
            label5.Text = "លេខគណនី";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kh Battambang", 15.75F);
            label3.Location = new Point(338, 4);
            label3.Name = "label3";
            label3.Size = new Size(131, 38);
            label3.TabIndex = 2;
            label3.Text = "ទឹកប្រាក់សរុប";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Battambang", 15.75F);
            label2.Location = new Point(182, 4);
            label2.Name = "label2";
            label2.Size = new Size(116, 38);
            label2.TabIndex = 1;
            label2.Text = "ទឹកប្រាក់ដក";
            // 
            // lblAccNo
            // 
            lblAccNo.AutoSize = true;
            lblAccNo.Font = new Font("Kh Battambang", 15.75F);
            lblAccNo.Location = new Point(39, 143);
            lblAccNo.Name = "lblAccNo";
            lblAccNo.Size = new Size(117, 38);
            lblAccNo.TabIndex = 16;
            lblAccNo.Text = "លេខគណនី";
            // 
            // lblbl
            // 
            lblbl.AutoSize = true;
            lblbl.Font = new Font("Kh Battambang", 15.75F);
            lblbl.Location = new Point(361, 143);
            lblbl.Name = "lblbl";
            lblbl.Size = new Size(91, 38);
            lblbl.TabIndex = 15;
            lblbl.Text = "Balance";
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Font = new Font("Kh Battambang", 15.75F);
            lblDeposit.Location = new Point(186, 143);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(182, 38);
            lblDeposit.TabIndex = 14;
            lblDeposit.Text = "Withdraw Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Moul", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 58);
            label1.TabIndex = 12;
            label1.Text = "វិក័យបត្រ";
            // 
            // WithDrawReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 543);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(lblAccNo);
            Controls.Add(lblbl);
            Controls.Add(lblDeposit);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WithDrawReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WithDrawReport";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label lblAccNo;
        private Label lblbl;
        private Label lblDeposit;
        private Label label1;
    }
}