using GlosySoftwareCase.DtoLayer.Dtos.Product;
using GlosySoftwareCase.EntityLayer.Concrete;
using Newtonsoft.Json;
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
    public partial class UpdateProduct : Form
    {
        private List<ProductDto_List> products = new List<ProductDto_List>(); // Ürün listesi
        public UpdateProduct()
        {
            InitializeComponent();
            RefreshDataGrid();
        }
        private async void Update_Click(object sender, EventArgs e)
        {
            await RefreshDataGrid(); // Form yüklendiğinde datagrid'i güncelle
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7171/");

                var updatedProduct = new ProductDto_List
                {
                    Id = int.Parse(textBoxId.Text), // Güncellenecek ürünün ID'si
                    ProductName = textBoxName.Text,
                    ProductPrice = decimal.Parse(textBoxPrice.Text),
                    ProductAmount = int.Parse(textBoxAmount.Text),
                    ProductDetail = textBoxDetail.Text
                };

                string json = JsonConvert.SerializeObject(updatedProduct);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync($"api/Products/UpdateProduct/", content);
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Ürün başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await RefreshDataGrid(); // Datagrid'i güncelle
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Ürünleri listelemek için API'den veri çeken metod
        private async Task RefreshDataGrid()
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7171/");

                HttpResponseMessage response = await client.GetAsync($"api/Products/ProductList");
                response.EnsureSuccessStatusCode();
                string result = await response.Content.ReadAsStringAsync();

                products = JsonConvert.DeserializeObject<List<ProductDto_List>>(result);

                // Datagrid'e ürünleri yükle
                dataGridView1.DataSource = products;

                // Datagrid'i yenile
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Listele butonuna tıklandığında çalışacak metod
        private async void button1_Click(object sender, EventArgs e)
        {
            await RefreshDataGrid(); // Listele butonuna basıldığında datagrid'i güncelle
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Seçilen satırdaki ürünü al
                ProductDto_List selectedProduct = products[e.RowIndex];

                // Ürün bilgilerini ilgili TextBox'lara aktar
                textBoxId.Text = selectedProduct.Id.ToString();
                textBoxName.Text = selectedProduct.ProductName;
                textBoxPrice.Text = selectedProduct.ProductPrice.ToString();
                textBoxAmount.Text = selectedProduct.ProductAmount.ToString();
                textBoxDetail.Text = selectedProduct.ProductDetail;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gecis otherForm = new Gecis();
            otherForm.Show();
            this.Hide();
        }
    }
}
