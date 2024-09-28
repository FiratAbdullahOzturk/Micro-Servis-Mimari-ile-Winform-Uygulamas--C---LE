namespace WinFormsApp
{
    partial class DeleteProduct
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
            buttonDeleteCategory = new Button();
            textBoxCategoryId = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonDeleteCategory
            // 
            buttonDeleteCategory.Location = new Point(21, 156);
            buttonDeleteCategory.Name = "buttonDeleteCategory";
            buttonDeleteCategory.Size = new Size(93, 42);
            buttonDeleteCategory.TabIndex = 27;
            buttonDeleteCategory.Text = "Delete";
            buttonDeleteCategory.UseVisualStyleBackColor = true;
            buttonDeleteCategory.Click += buttonDeleteCategory_Click;
            // 
            // textBoxCategoryId
            // 
            textBoxCategoryId.Location = new Point(144, 167);
            textBoxCategoryId.Name = "textBoxCategoryId";
            textBoxCategoryId.Size = new Size(100, 23);
            textBoxCategoryId.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(272, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(466, 363);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.Click += Delete_Click;
            // 
            // button1
            // 
            button1.Location = new Point(21, 96);
            button1.Name = "button1";
            button1.Size = new Size(93, 43);
            button1.TabIndex = 29;
            button1.Text = "Lıst";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(37, 39);
            button2.TabIndex = 30;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DeleteProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDeleteCategory);
            Controls.Add(textBoxCategoryId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteProduct";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDeleteCategory;
        private TextBox textBoxCategoryId;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
    }
}