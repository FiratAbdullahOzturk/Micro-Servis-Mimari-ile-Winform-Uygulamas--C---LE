using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Gecis : Form
    {
        public Gecis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Diğer formu oluşturup göster
            ListProduct otherForm = new ListProduct();
            otherForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Diğer formu oluşturup göster
            UploadProduct otherForm = new UploadProduct();
            otherForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Diğer formu oluşturup göster
            UpdateProduct otherForm = new UpdateProduct();
            otherForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Diğer formu oluşturup göster
            DeleteProduct otherForm = new DeleteProduct();
            otherForm.Show();
            this.Hide();
        }
    }
}
