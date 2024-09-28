using System.Text.Json;
using System;
using Azure;
using GlosySoftwareCase.DtoLayer.Dtos.ProductDto;
using GlosySoftwareCase.EntityLayer.Concrete;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Forms;
using GlosySoftwareCase.DtoLayer.Dtos.Product;


namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        //https://localhost:7171/api/Products/ProductList
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7171/api/Products/ProductList");
            HttpResponseMessage response = await client.GetAsync("");
            string result = await response.Content.ReadAsStringAsync();

            List<ProductDto_List> products = JsonConvert.DeserializeObject<List<ProductDto_List>>(result);

            StringBuilder displayId = new StringBuilder();
            foreach (var product in products)
            {
                displayId.AppendLine($"Product ID: {product.Id}");

            }

            label1.Text = displayId.ToString();

            StringBuilder displayTextName = new StringBuilder();
            foreach (var product in products)
            {
                displayTextName.AppendLine($"Product Name: {product.ProductName}");
            }

            label2.Text = displayTextName.ToString();

            StringBuilder displayTextPrice = new StringBuilder();
            foreach (var product in products)
            {
                displayTextPrice.AppendLine($"Product Price: {product.ProductPrice}");
            }

            label3.Text = displayTextPrice.ToString();

            StringBuilder displayTextAmount = new StringBuilder();
            foreach (var product in products)
            {
                displayTextAmount.AppendLine($"Product Amount: {product.ProductAmount}");
            }

            label4.Text = displayTextAmount.ToString();

            StringBuilder displayTextDetail = new StringBuilder();
            foreach (var product in products)
            {
                displayTextDetail.AppendLine($"Product Detail: {product.ProductDetail}");
            }

            label5.Text = displayTextDetail.ToString();



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                string id = textBox1.Text;
                client.BaseAddress = new Uri("https://localhost:7171/");

                HttpResponseMessage response = await client.GetAsync($"api/Products/GetById/{id}");
                response.EnsureSuccessStatusCode();
                string result = await response.Content.ReadAsStringAsync();

                ProductDto_List product = System.Text.Json.JsonSerializer.Deserialize<ProductDto_List>(result, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (product != null)
                {
                    StringBuilder productDetails = new StringBuilder();
                    productDetails.AppendLine($"Product ID: {product.Id}");
                    productDetails.AppendLine($"Product Name: {product.ProductName}");
                    productDetails.AppendLine($"Product Price: {product.ProductPrice}");
                    productDetails.AppendLine($"Product Amount: {product.ProductAmount}");
                    productDetails.AppendLine($"Product Detail: {product.ProductDetail}");

                    label6.Text = productDetails.ToString();
                }
                else
                {
                    label6.Text = "Product not found.";
                }
            }
            catch (Exception ex)
            {
                label6.Text = $"An error occurred: {ex.Message}";
            }


        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // HttpClient nesnesi oluştur
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7171/");

                // Yeni ürün oluştur
                var newProduct = new ProductDto_List
                {

                    ProductName = textBoxName.Text,
                    ProductPrice = decimal.Parse(textBoxPrice.Text),
                    ProductAmount = int.Parse(textBoxAmount.Text),
                    ProductDetail = textBoxDetail.Text
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

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7171");

                    // Güncellenmiş ürün oluştur, labellardan verileri al
                    var updatedProduct = new ProductDto_List
                    {
                        Id = int.Parse(labelUpdateProductID.Text),
                        ProductName = labelUpdateProductName.Text,
                        ProductPrice = decimal.Parse(labelUpdateProductPrice.Text),
                        ProductAmount = int.Parse(labelUpdateProductAmount.Text),
                        ProductDetail = labelUpdateProductDetail.Text
                    };

                    // JSON formatında ürünü dönüştür
                    string json = System.Text.Json.JsonSerializer.Serialize(updatedProduct);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // PUT isteği gönder
                    HttpResponseMessage response = await client.PutAsync($"api/Products/UpdateProduct{updatedProduct.Id}", content);

                    if (response.IsSuccessStatusCode)
                    {
                        labelUpdateResult.Text = "Ürün başarıyla güncellendi!";
                    }
                    else
                    {
                        MessageBox.Show("Ürün güncellenemedi: " + response.StatusCode);
                    }
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show("HTTP isteğinde bir hata oluştu: " + httpEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }


    }
}

