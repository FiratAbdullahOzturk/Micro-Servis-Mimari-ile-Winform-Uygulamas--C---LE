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
    public partial class UploadProduct : Form
    {
        private List<ProductDto_List> products = new List<ProductDto_List>(); // Ürün listesi
        public UploadProduct()
        {
            InitializeComponent();
            RefreshDataGrid();

        }
        private async void Upload_Click(object sender, EventArgs e)
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
        private async void button2_Click(object sender, EventArgs e)
        {
            await RefreshDataGrid(); // Listele butonuna basıldığında datagrid'i güncelle
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

        private void button1_Click(object sender, EventArgs e)
        {
            Gecis otherForm = new Gecis();
            otherForm.Show();
            this.Hide();
        }
    }
}
