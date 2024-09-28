namespace WinFormsApp
{
    partial class UpdateProduct
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
            textBoxId = new TextBox();
            textBoxDetail = new TextBox();
            textBoxAmount = new TextBox();
            textBoxPrice = new TextBox();
            textBoxName = new TextBox();
            button3 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(136, 101);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 11;
            // 
            // textBoxDetail
            // 
            textBoxDetail.Location = new Point(136, 269);
            textBoxDetail.Name = "textBoxDetail";
            textBoxDetail.Size = new Size(100, 23);
            textBoxDetail.TabIndex = 10;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(136, 227);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(100, 23);
            textBoxAmount.TabIndex = 9;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(136, 184);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 8;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(136, 140);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(12, 177);
            button3.Name = "button3";
            button3.Size = new Size(88, 30);
            button3.TabIndex = 12;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 132);
            button1.Name = "button1";
            button1.Size = new Size(88, 31);
            button1.TabIndex = 13;
            button1.Text = "Lıst";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(270, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(466, 363);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.Click += Update_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(37, 39);
            button2.TabIndex = 15;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(textBoxId);
            Controls.Add(textBoxDetail);
            Controls.Add(textBoxAmount);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateProduct";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxId;
        private TextBox textBoxDetail;
        private TextBox textBoxAmount;
        private TextBox textBoxPrice;
        private TextBox textBoxName;
        private Button button3;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
    }
}