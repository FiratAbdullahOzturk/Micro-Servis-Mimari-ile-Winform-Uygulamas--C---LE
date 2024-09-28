namespace WinFormsApp
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            textBoxAmount = new TextBox();
            textBoxDetail = new TextBox();
            textBoxId = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBoxDetail1 = new TextBox();
            textBoxAmount1 = new TextBox();
            textBoxPrice1 = new TextBox();
            textBoxName1 = new TextBox();
            label7 = new Label();
            button4 = new Button();
            textBoxCategoryId = new TextBox();
            buttonDeleteCategory = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(474, 189);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(536, 98);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(536, 142);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 3;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(536, 185);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(100, 23);
            textBoxAmount.TabIndex = 4;
            // 
            // textBoxDetail
            // 
            textBoxDetail.Location = new Point(536, 227);
            textBoxDetail.Name = "textBoxDetail";
            textBoxDetail.Size = new Size(100, 23);
            textBoxDetail.TabIndex = 5;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(536, 59);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(681, 59);
            button1.Name = "button1";
            button1.Size = new Size(88, 31);
            button1.TabIndex = 7;
            button1.Text = "Lıst";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(681, 96);
            button2.Name = "button2";
            button2.Size = new Size(88, 32);
            button2.TabIndex = 8;
            button2.Text = "find product";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(681, 134);
            button3.Name = "button3";
            button3.Size = new Size(88, 30);
            button3.TabIndex = 9;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBoxDetail1
            // 
            textBoxDetail1.Location = new Point(147, 489);
            textBoxDetail1.Name = "textBoxDetail1";
            textBoxDetail1.Size = new Size(100, 23);
            textBoxDetail1.TabIndex = 23;
            // 
            // textBoxAmount1
            // 
            textBoxAmount1.Location = new Point(147, 443);
            textBoxAmount1.Name = "textBoxAmount1";
            textBoxAmount1.Size = new Size(100, 23);
            textBoxAmount1.TabIndex = 22;
            // 
            // textBoxPrice1
            // 
            textBoxPrice1.Location = new Point(147, 396);
            textBoxPrice1.Name = "textBoxPrice1";
            textBoxPrice1.Size = new Size(100, 23);
            textBoxPrice1.TabIndex = 21;
            // 
            // textBoxName1
            // 
            textBoxName1.Location = new Point(147, 351);
            textBoxName1.Name = "textBoxName1";
            textBoxName1.Size = new Size(100, 23);
            textBoxName1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(165, 313);
            label7.Name = "label7";
            label7.Size = new Size(49, 21);
            label7.TabIndex = 19;
            label7.Text = "Reply";
            // 
            // button4
            // 
            button4.Location = new Point(41, 305);
            button4.Name = "button4";
            button4.Size = new Size(101, 41);
            button4.TabIndex = 18;
            button4.Text = "Upload Product";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBoxCategoryId
            // 
            textBoxCategoryId.Location = new Point(472, 315);
            textBoxCategoryId.Name = "textBoxCategoryId";
            textBoxCategoryId.Size = new Size(100, 23);
            textBoxCategoryId.TabIndex = 24;
            // 
            // buttonDeleteCategory
            // 
            buttonDeleteCategory.Location = new Point(349, 304);
            buttonDeleteCategory.Name = "buttonDeleteCategory";
            buttonDeleteCategory.Size = new Size(93, 42);
            buttonDeleteCategory.TabIndex = 25;
            buttonDeleteCategory.Text = "Delete";
            buttonDeleteCategory.UseVisualStyleBackColor = true;
            buttonDeleteCategory.Click += buttonDeleteCategory_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 556);
            Controls.Add(buttonDeleteCategory);
            Controls.Add(textBoxCategoryId);
            Controls.Add(textBoxDetail1);
            Controls.Add(textBoxAmount1);
            Controls.Add(textBoxPrice1);
            Controls.Add(textBoxName1);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxId);
            Controls.Add(textBoxDetail);
            Controls.Add(textBoxAmount);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private TextBox textBoxAmount;
        private TextBox textBoxDetail;
        private TextBox textBoxId;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBoxDetail1;
        private TextBox textBoxAmount1;
        private TextBox textBoxPrice1;
        private TextBox textBoxName1;
        private Label label7;
        private Button button4;
        private DataGridView dataGridView1;
        private TextBox textBoxCategoryId;
        private Button buttonDeleteCategory;
    }
}