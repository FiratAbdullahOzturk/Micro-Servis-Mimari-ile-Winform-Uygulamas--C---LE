using GlosySoftwareCase.DtoLayer.Dtos.ProductDto;
using GlosySoftwareCase.EntityLayer.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp
{
    public partial class ListProduct : Form
    {
        private List<ResultProductDto> products = new List<ResultProductDto>(); // Ürün listesi
        public ListProduct()
        {
            InitializeComponent();
            RefreshDataGrid();
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

                products = JsonConvert.DeserializeObject<List<ResultProductDto>>(result);

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

                ResultProductDto product = JsonConvert.DeserializeObject<ResultProductDto>(result);

                if (product != null)
                {
                    // Ürün bilgilerini form üzerinde göster
                    textBoxId.Text = product.ProductID.ToString();
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
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Seçilen satırdaki ürünü al
                ResultProductDto selectedProduct = products[e.RowIndex];

                // Ürün bilgilerini ilgili TextBox'lara aktar
                textBoxId.Text = selectedProduct.ProductID.ToString();
                textBoxName.Text = selectedProduct.ProductName;
                textBoxPrice.Text = selectedProduct.ProductPrice.ToString();
                textBoxAmount.Text = selectedProduct.ProductAmount.ToString();
                textBoxDetail.Text = selectedProduct.ProductDetail;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Gecis otherForm = new Gecis();
            otherForm.Show();
            this.Hide();
        }
        // Filtreleme butonuna tıklandığında çalışacak metod
        private async void btnFilter_Click(object sender, EventArgs e)
        {
             ApplyFilter();
        }

        // Filtreleme işlemini gerçekleştiren metod
        // Filtreleme işlemini gerçekleştiren metod
        private void ApplyFilter()
        {
            // TextBox'lardaki filtre değerlerini alın
            string id = txtFilterID.Text;
            string amount = txtFilterAmount.Text;
            string name = txtFilterName.Text;
            string price = txtFilterPrice.Text;

            // Filtreleme için bir expression oluşturun
            Expression<Func<ResultProductDto, bool>> filterExpression = p =>
                (string.IsNullOrEmpty(id) || p.ProductID.ToString().Contains(id)) &&
                (string.IsNullOrEmpty(amount) || p.ProductAmount.ToString().Contains(amount)) &&
                (string.IsNullOrEmpty(name) || p.ProductName.Contains(name)) &&
                (string.IsNullOrEmpty(price) || (p.ProductCalPrice).ToString().Contains(price));

            // Ürün listesini filtreleyin
            var filteredProducts = products.AsQueryable().Where(filterExpression).ToList();

            // Datagrid'e filtrelenmiş ürünleri yükle
            dataGridView1.DataSource = filteredProducts;

            // Datagrid'i yenile
            dataGridView1.Refresh();
        }
    }
}


