namespace BankProject
{
    partial class NoMoneyVal
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
            panel1 = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.exit2;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Location = new Point(26, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(54, 52);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Moul", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(86, 66);
            label1.Name = "label1";
            label1.Size = new Size(242, 38);
            label1.TabIndex = 4;
            label1.Text = "ទឹកប្រាក់មិនគ្រប់គ្រាន់";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NoMoney
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 170);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "NoMoney";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoMoney";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
    }
}