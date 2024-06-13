namespace BankProject
{
    partial class NoAccountValCus
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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Moul", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(95, 66);
            label1.Name = "label1";
            label1.Size = new Size(166, 38);
            label1.TabIndex = 0;
            label1.Text = "មិនមានគណនី";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.exit2;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Location = new Point(35, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(54, 52);
            panel1.TabIndex = 1;
            // 
            // NoAccountValCus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 170);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "NoAccountValCus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Message";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
    }
}