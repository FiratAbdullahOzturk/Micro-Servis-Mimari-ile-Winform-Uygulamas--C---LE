using GlosySoftwareCase.DtoLayer.Dtos.Product;
using GlosySoftwareCase.EntityLayer.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form2 : Form
    {
        private List<ProductDto_List> products = new List<ProductDto_List>(); // Ürün listesi
        public Form2()
        {
            InitializeComponent();
        }
        private async void Form2_Load(object sender, EventArgs e)
        {
            await RefreshDataGrid(); // Form yüklendiğinde datagrid'i güncelle
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

        // ID'ye göre ürünü getiren metod
        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7171/");

                string id = textBox1.Text;

                HttpResponseMessage response = await client.GetAsync($"api/Products/GetById/{id}");
                response.EnsureSuccessStatusCode();
                string result = await response.Content.ReadAsStringAsync();

                ProductDto_List product = JsonConvert.DeserializeObject<ProductDto_List>(result);

                if (product != null)
                {
                    // Ürün bilgilerini form üzerinde göster
                    textBoxId.Text = product.Id.ToString();
                    textBoxName.Text = product.ProductName;
                    textBoxPrice.Text = product.ProductPrice.ToString();
                    textBoxAmount.Text = product.ProductAmount.ToString();
                    textBoxDetail.Text = product.ProductDetail;
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Yeni ürün eklemek için metod
        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // HttpClient nesnesi oluştur
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7171/");

                // Yeni ürün oluştur
                var newProduct = new ProductDto_List
                {
                    ProductName = textBoxName1.Text,
                    ProductPrice = decimal.Parse(textBoxPrice1.Text),
                    ProductAmount = int.Parse(textBoxAmount1.Text),
                    ProductDetail = textBoxDetail1.Text
                };

                // Ürünü JSON formatına dönüştür
                string json = System.Text.Json.JsonSerializer.Serialize(newProduct);

                // JSON içeriğini StringContent olarak ayarla
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // POST isteği gönder
                HttpResponseMessage response = await client.PostAsync("api/Products/CreateProduct", content);
                response.EnsureSuccessStatusCode();

                // Başarılı olduğunda mesaj göster
                label7.Text = "Ürün başarıyla eklendi!";
            }
            // İstek sırasında oluşan hataları yakala ve işle
            catch (Exception ex)
            {
                label7.Text = $"Bir hata oluştu: {ex.Message}";
            }
        }

        // Ürün güncellemek için metod
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

        // Ürünü silmek için metod
        private async void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7171/");

                string categoryId = textBoxCategoryId.Text;

                HttpResponseMessage response = await client.DeleteAsync($"api/Products/DeleteCategory/{categoryId}");
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Kategoriye ait ürünler başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await RefreshDataGrid(); // Datagrid'i güncelle
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
