namespace WinFormsApp
{
    partial class Gecis
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
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(190, 24);
            button1.Name = "button1";
            button1.Size = new Size(158, 151);
            button1.TabIndex = 0;
            button1.Text = "List Product";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(415, 24);
            button3.Name = "button3";
            button3.Size = new Size(158, 151);
            button3.TabIndex = 2;
            button3.Text = "Upload Product";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(190, 200);
            button4.Name = "button4";
            button4.Size = new Size(158, 151);
            button4.TabIndex = 3;
            button4.Text = "Update Product";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(415, 200);
            button5.Name = "button5";
            button5.Size = new Size(158, 151);
            button5.TabIndex = 4;
            button5.Text = "Delete Product";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Gecis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Gecis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}