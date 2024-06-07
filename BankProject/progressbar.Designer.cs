namespace BankProject
{
    partial class ProgressBar
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
            components = new System.ComponentModel.Container();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(40, 177);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(501, 66);
            progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 246);
            label1.Name = "label1";
            label1.Size = new Size(216, 38);
            label1.TabIndex = 1;
            label1.Text = "Loading Please Wait..";
            // 
            // ProgressBar
            // 
            AutoScaleDimensions = new SizeF(12F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 455);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Font = new Font("Kh Battambang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 8, 5, 8);
            Name = "ProgressBar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProgressBar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}