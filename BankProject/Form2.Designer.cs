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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button5 = new Button();
            btnsave = new Button();
            btndelete = new Button();
            dataGridView1 = new DataGridView();
            btnupdate = new Button();
            btnedit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            btnsave.BackColor = SystemColors.Control;
            btnsave.BackgroundImage = (Image)resources.GetObject("btnsave.BackgroundImage");
            btnsave.BackgroundImageLayout = ImageLayout.Zoom;
            btnsave.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(174, 433);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(109, 49);
            btnsave.TabIndex = 10;
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = SystemColors.Control;
            btndelete.BackgroundImage = (Image)resources.GetObject("btndelete.BackgroundImage");
            btndelete.BackgroundImageLayout = ImageLayout.Zoom;
            btndelete.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.ForeColor = SystemColors.ActiveCaptionText;
            btndelete.Location = new Point(644, 433);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(109, 49);
            btndelete.TabIndex = 13;
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(98, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(761, 386);
            dataGridView1.TabIndex = 14;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = SystemColors.Control;
            btnupdate.BackgroundImage = (Image)resources.GetObject("btnupdate.BackgroundImage");
            btnupdate.BackgroundImageLayout = ImageLayout.Zoom;
            btnupdate.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.ForeColor = SystemColors.ActiveCaptionText;
            btnupdate.Location = new Point(330, 433);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(109, 49);
            btnupdate.TabIndex = 15;
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click_1;
            // 
            // btnedit
            // 
            btnedit.BackColor = SystemColors.Control;
            btnedit.BackgroundImage = (Image)resources.GetObject("btnedit.BackgroundImage");
            btnedit.BackgroundImageLayout = ImageLayout.Zoom;
            btnedit.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnedit.ForeColor = SystemColors.ActiveCaptionText;
            btnedit.Location = new Point(485, 433);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(109, 49);
            btnedit.TabIndex = 16;
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 709);
            Controls.Add(btnedit);
            Controls.Add(btnupdate);
            Controls.Add(dataGridView1);
            Controls.Add(btndelete);
            Controls.Add(btnsave);
            Controls.Add(button5);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button5;
        private Button btnsave;
        private Button btnedit;
        private Button button3;
        private Button btndelete;
        private DataGridView dataGridView1;
        private Button btnupdate;
    }
}