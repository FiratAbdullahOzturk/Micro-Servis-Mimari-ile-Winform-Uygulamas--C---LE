namespace WinFormsApp
{
    partial class UploadProduct
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
            textBoxDetail1 = new TextBox();
            textBoxAmount1 = new TextBox();
            textBoxPrice1 = new TextBox();
            textBoxName1 = new TextBox();
            label7 = new Label();
            button4 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxDetail1
            // 
            textBoxDetail1.Location = new Point(140, 249);
            textBoxDetail1.Name = "textBoxDetail1";
            textBoxDetail1.Size = new Size(100, 23);
            textBoxDetail1.TabIndex = 29;
            // 
            // textBoxAmount1
            // 
            textBoxAmount1.Location = new Point(140, 206);
            textBoxAmount1.Name = "textBoxAmount1";
            textBoxAmount1.Size = new Size(100, 23);
            textBoxAmount1.TabIndex = 28;
            // 
            // textBoxPrice1
            // 
            textBoxPrice1.Location = new Point(140, 163);
            textBoxPrice1.Name = "textBoxPrice1";
            textBoxPrice1.Size = new Size(100, 23);
            textBoxPrice1.TabIndex = 27;
            // 
            // textBoxName1
            // 
            textBoxName1.Location = new Point(140, 118);
            textBoxName1.Name = "textBoxName1";
            textBoxName1.Size = new Size(100, 23);
            textBoxName1.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(150, 81);
            label7.Name = "label7";
            label7.Size = new Size(49, 21);
            label7.TabIndex = 25;
            label7.Text = "Reply";
            // 
            // button4
            // 
            button4.Location = new Point(12, 154);
            button4.Name = "button4";
            button4.Size = new Size(101, 49);
            button4.TabIndex = 24;
            button4.Text = "Upload Product";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1, 0);
            button1.Name = "button1";
            button1.Size = new Size(37, 44);
            button1.TabIndex = 30;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(302, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(466, 363);
            dataGridView1.TabIndex = 32;
            dataGridView1.Click += Upload_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 81);
            button2.Name = "button2";
            button2.Size = new Size(101, 49);
            button2.TabIndex = 33;
            button2.Text = "Lıst";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UploadProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBoxDetail1);
            Controls.Add(textBoxAmount1);
            Controls.Add(textBoxPrice1);
            Controls.Add(textBoxName1);
            Controls.Add(label7);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UploadProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UploadProduct";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDetail1;
        private TextBox textBoxAmount1;
        private TextBox textBoxPrice1;
        private TextBox textBoxName1;
        private Label label7;
        private Button button4;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
    }
}