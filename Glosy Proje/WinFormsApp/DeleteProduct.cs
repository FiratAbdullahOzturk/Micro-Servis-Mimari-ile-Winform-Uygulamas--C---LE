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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp
{
    public partial class DeleteProduct : Form
    {
        private List<ProductDto_List> products = new List<ProductDto_List>(); // Ürün listesi
        public DeleteProduct()
        {
            InitializeComponent();
            RefreshDataGrid();
        }
        private async void Delete_Click(object sender, EventArgs e)
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
                textBoxCategoryId.Text = selectedProduct.Id.ToString();
               
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
