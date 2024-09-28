namespace WinFormsApp
{
    partial class ListProduct
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
            button2 = new Button();
            button1 = new Button();
            textBoxId = new TextBox();
            textBoxDetail = new TextBox();
            textBoxAmount = new TextBox();
            textBoxPrice = new TextBox();
            textBoxName = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            txtFilterID = new TextBox();
            txtFilterAmount = new TextBox();
            txtFilterName = new TextBox();
            txtFilterPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(532, 397);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // button2
            // 
            button2.Location = new Point(550, 3);
            button2.Name = "button2";
            button2.Size = new Size(88, 32);
            button2.TabIndex = 10;
            button2.Text = "find product";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(550, 71);
            button1.Name = "button1";
            button1.Size = new Size(88, 31);
            button1.TabIndex = 9;
            button1.Text = "Lıst";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(550, 108);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 15;
            // 
            // textBoxDetail
            // 
            textBoxDetail.Location = new Point(550, 280);
            textBoxDetail.Name = "textBoxDetail";
            textBoxDetail.Size = new Size(100, 23);
            textBoxDetail.TabIndex = 14;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(550, 238);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(100, 23);
            textBoxAmount.TabIndex = 13;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(550, 195);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 12;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(550, 151);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(550, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 16;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(31, 41);
            button3.TabIndex = 17;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(686, 71);
            button4.Name = "button4";
            button4.Size = new Size(88, 33);
            button4.TabIndex = 18;
            button4.Text = "Filter";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnFilter_Click;
            // 
            // txtFilterID
            // 
            txtFilterID.Location = new Point(686, 110);
            txtFilterID.Name = "txtFilterID";
            txtFilterID.Size = new Size(100, 23);
            txtFilterID.TabIndex = 19;
            // 
            // txtFilterAmount
            // 
            txtFilterAmount.Location = new Point(686, 195);
            txtFilterAmount.Name = "txtFilterAmount";
            txtFilterAmount.Size = new Size(100, 23);
            txtFilterAmount.TabIndex = 20;
            // 
            // txtFilterName
            // 
            txtFilterName.Location = new Point(686, 151);
            txtFilterName.Name = "txtFilterName";
            txtFilterName.Size = new Size(100, 23);
            txtFilterName.TabIndex = 21;
            // 
            // txtFilterPrice
            // 
            txtFilterPrice.Location = new Point(686, 238);
            txtFilterPrice.Name = "txtFilterPrice";
            txtFilterPrice.Size = new Size(100, 23);
            txtFilterPrice.TabIndex = 22;
            // 
            // ListProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFilterPrice);
            Controls.Add(txtFilterName);
            Controls.Add(txtFilterAmount);
            Controls.Add(txtFilterID);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(textBoxId);
            Controls.Add(textBoxDetail);
            Controls.Add(textBoxAmount);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "7";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private TextBox textBoxId;
        private TextBox textBoxDetail;
        private TextBox textBoxAmount;
        private TextBox textBoxPrice;
        private TextBox textBoxName;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private TextBox txtFilterID;
        private TextBox txtFilterAmount;
        private TextBox txtFilterName;
        private TextBox txtFilterPrice;
    }
}