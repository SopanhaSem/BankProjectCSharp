namespace BankProject
{
    partial class StaffLogin
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
            textBox1 = new TextBox();
            txtpass = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 74);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ឈ្មោះ​អ្នកប្រើប្រាស់";
            textBox1.Size = new Size(318, 43);
            textBox1.TabIndex = 0;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(108, 139);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.PlaceholderText = "ពាក្យសម្ងាត់";
            txtpass.Size = new Size(318, 43);
            txtpass.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Location = new Point(139, 188);
            button1.Name = "button1";
            button1.Size = new Size(112, 47);
            button1.TabIndex = 4;
            button1.Text = "ចូល";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(266, 188);
            button2.Name = "button2";
            button2.Size = new Size(112, 47);
            button2.TabIndex = 51;
            button2.Text = "ចាកចេញ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Moul", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 49);
            label1.TabIndex = 52;
            label1.Text = "ចូលប្រព័ន្ធ";
            // 
            // StaffLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 293);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtpass);
            Controls.Add(textBox1);
            Font = new Font("Kh Battambang", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 7, 4, 7);
            Name = "StaffLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffLogin";
            Load += StaffLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox txtpass;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}