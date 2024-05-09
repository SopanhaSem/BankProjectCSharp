namespace BankProject
{
    partial class Form2
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
            button5 = new Button();
            btnsave = new Button();
            btndelete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 28);
            label1.Name = "label1";
            label1.Size = new Size(305, 36);
            label1.TabIndex = 1;
            label1.Text = "Account Information";
            label1.Click += label1_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(12, 12);
            button5.Name = "button5";
            button5.Size = new Size(80, 40);
            button5.TabIndex = 7;
            button5.Text = "←";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.FromArgb(128, 128, 255);
            btnsave.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(299, 486);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(109, 49);
            btnsave.TabIndex = 10;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.ForeColor = SystemColors.ActiveCaptionText;
            btndelete.Location = new Point(473, 486);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(109, 49);
            btndelete.TabIndex = 13;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(761, 386);
            dataGridView1.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 588);
            Controls.Add(dataGridView1);
            Controls.Add(btndelete);
            Controls.Add(btnsave);
            Controls.Add(button5);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button5;
        private Button btnsave;
        private Button button2;
        private Button button3;
        private Button btndelete;
        private DataGridView dataGridView1;
    }
}