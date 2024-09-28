namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label6 = new Label();
            button3 = new Button();
            label7 = new Label();
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            textBoxAmount = new TextBox();
            textBoxDetail = new TextBox();
            button4 = new Button();
            labelUpdateResult = new Label();
            labelUpdateProductName = new TextBox();
            labelUpdateProductPrice = new TextBox();
            labelUpdateProductAmount = new TextBox();
            labelUpdateProductDetail = new TextBox();
            labelUpdateProductID = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(261, 26);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(140, 36);
            button1.TabIndex = 0;
            button1.Text = "LIST PRODUCT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 100);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "ProductId";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 100);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 4;
            label2.Text = "ProductName";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 100);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 5;
            label3.Text = "ProductPrice";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 100);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 6;
            label4.Text = "ProductAmount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(606, 100);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 7;
            label5.Text = "ProductDetail";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 244);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(22, 244);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(101, 23);
            button2.TabIndex = 9;
            button2.Text = "Choose id";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(160, 288);
            label6.Name = "label6";
            label6.Size = new Size(39, 21);
            label6.TabIndex = 10;
            label6.Text = "LIST";
            // 
            // button3
            // 
            button3.Location = new Point(22, 376);
            button3.Name = "button3";
            button3.Size = new Size(101, 41);
            button3.TabIndex = 11;
            button3.Text = "Upload Product";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(166, 396);
            label7.Name = "label7";
            label7.Size = new Size(49, 21);
            label7.TabIndex = 12;
            label7.Text = "Reply";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(166, 471);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 14;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(166, 516);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 15;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(166, 563);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(100, 23);
            textBoxAmount.TabIndex = 16;
            // 
            // textBoxDetail
            // 
            textBoxDetail.Location = new Point(166, 608);
            textBoxDetail.Name = "textBoxDetail";
            textBoxDetail.Size = new Size(100, 23);
            textBoxDetail.TabIndex = 17;
            // 
            // button4
            // 
            button4.Location = new Point(383, 381);
            button4.Name = "button4";
            button4.Size = new Size(116, 44);
            button4.TabIndex = 18;
            button4.Text = "Update Product";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // labelUpdateResult
            // 
            labelUpdateResult.AutoSize = true;
            labelUpdateResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUpdateResult.Location = new Point(528, 396);
            labelUpdateResult.Name = "labelUpdateResult";
            labelUpdateResult.Size = new Size(49, 21);
            labelUpdateResult.TabIndex = 19;
            labelUpdateResult.Text = "Reply";
            // 
            // labelUpdateProductName
            // 
            labelUpdateProductName.Location = new Point(516, 499);
            labelUpdateProductName.Name = "labelUpdateProductName";
            labelUpdateProductName.Size = new Size(100, 23);
            labelUpdateProductName.TabIndex = 20;
            // 
            // labelUpdateProductPrice
            // 
            labelUpdateProductPrice.Location = new Point(516, 546);
            labelUpdateProductPrice.Name = "labelUpdateProductPrice";
            labelUpdateProductPrice.Size = new Size(100, 23);
            labelUpdateProductPrice.TabIndex = 21;
            // 
            // labelUpdateProductAmount
            // 
            labelUpdateProductAmount.Location = new Point(516, 590);
            labelUpdateProductAmount.Name = "labelUpdateProductAmount";
            labelUpdateProductAmount.Size = new Size(100, 23);
            labelUpdateProductAmount.TabIndex = 22;
            // 
            // labelUpdateProductDetail
            // 
            labelUpdateProductDetail.Location = new Point(516, 633);
            labelUpdateProductDetail.Name = "labelUpdateProductDetail";
            labelUpdateProductDetail.Size = new Size(100, 23);
            labelUpdateProductDetail.TabIndex = 23;
            // 
            // labelUpdateProductID
            // 
            labelUpdateProductID.Location = new Point(516, 452);
            labelUpdateProductID.Name = "labelUpdateProductID";
            labelUpdateProductID.Size = new Size(100, 23);
            labelUpdateProductID.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 678);
            Controls.Add(labelUpdateProductID);
            Controls.Add(labelUpdateProductDetail);
            Controls.Add(labelUpdateProductAmount);
            Controls.Add(labelUpdateProductPrice);
            Controls.Add(labelUpdateProductName);
            Controls.Add(labelUpdateResult);
            Controls.Add(button4);
            Controls.Add(textBoxDetail);
            Controls.Add(textBoxAmount);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Button button2;
        private Label label6;
        private Button button3;
        private Label label7;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private TextBox textBoxAmount;
        private TextBox textBoxDetail;
        private Button button4;
        private Label labelUpdateResult;
        private TextBox labelUpdateProductName;
        private TextBox labelUpdateProductPrice;
        private TextBox labelUpdateProductAmount;
        private TextBox labelUpdateProductDetail;
        private TextBox labelUpdateProductID;
    }
}
