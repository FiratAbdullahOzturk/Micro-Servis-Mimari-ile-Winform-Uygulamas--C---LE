using GlosySoftwareCase.Winform.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace GlosySoftwareCase.Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        async void  ProductList()
        {           
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7171/api/Products"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productJsonString = await response.Content.ReadAsStringAsync();

                        dataGridView1.DataSource = JsonConvert.DeserializeObject<Product[]>(productJsonString).ToList();

                    }
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            
            ProductList();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.ProductName = txtName.Text;
            product.ProductPrice = Convert.ToDecimal(txtPrice.Text);
            product.ProductAmount = Convert.ToInt32(txtPrice.Text);
            product.ProductDetail = txtDetail.Text;

            using (var client = new HttpClient())
            {
                var serializedProduct = JsonConvert.SerializeObject(product);
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("https://localhost:7171/api/Products", content);
            }
            ProductList();   
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductID =Convert.ToInt32(txtProductID.Text);
            product.ProductName = txtName.Text;
            product.ProductPrice = Convert.ToDecimal(txtPrice.Text);
            product.ProductAmount = Convert.ToInt32(txtAmount.Text);
            product.ProductDetail = txtDetail.Text;

            using (var client = new HttpClient())
            {
                var serializedProduct = JsonConvert.SerializeObject(product);
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                var result = await client.PutAsync("https://localhost:7171/api/Products/", content);
            }

            ProductList();

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductID = Convert.ToInt32(txtProductID.Text);

            product.ProductID = Convert.ToInt32(txtProductID.Text);
            using (var client = new HttpClient())
            {
                var result = await client.DeleteAsync($"https://localhost:7171/api/Products/{product.ProductID}");
            }
            ProductList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int clicked = dataGridView1.SelectedCells[0].RowIndex;

            string id = dataGridView1.Rows[clicked].Cells[0].Value.ToString();
            string name = dataGridView1.Rows[clicked].Cells[1].Value.ToString();
            string price = dataGridView1.Rows[clicked].Cells[2].Value.ToString();
            string amount = dataGridView1.Rows[clicked].Cells[3].Value.ToString();
            string detail = dataGridView1.Rows[clicked].Cells[4].Value.ToString();

            txtProductID.Text = id;
            txtName.Text = name;
            txtPrice.Text = price;
            txtAmount.Text = amount;
            txtDetail.Text = detail;
        }
    }
}


