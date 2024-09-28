using GlosySoftwareCase.DtoLayer.Dtos.ProductDto;
using GlosySoftwareCase.DtoLayer.Dtos.Product;
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
    public partial class Form3 : Form
    {
        private List<ProductDto_List> products = new List<ProductDto_List>(); // Ürün listesi
        public Form3()
        {
            InitializeComponent();
            RefreshDataGrid();
        }
        private async Task RefreshDataGrid()
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7171/");

                // ProductInfo verisini çek
                HttpResponseMessage responseInfo = await client.GetAsync($"api/Products/ProductList");
                responseInfo.EnsureSuccessStatusCode();
                string resultInfo = await responseInfo.Content.ReadAsStringAsync();
                var productInfos = JsonConvert.DeserializeObject<List<ProductInfo>>(resultInfo);

                // ProductCPrice verisini çek
                HttpResponseMessage responsePrice = await client.GetAsync($"api/Products/ProductList");
                responsePrice.EnsureSuccessStatusCode();
                string resultPrice = await responsePrice.Content.ReadAsStringAsync();
                var productCPrices = JsonConvert.DeserializeObject<List<ProductCPrice>>(resultPrice);

                // İki listeyi birleştir
                var combinedData = from info in productInfos
                                   join price in productCPrices on info.Id equals price.Id
                                   select new ProductDto_List
                                   {
                                       Id = info.Id,
                                       ProductName = info.ProductName,
                                       ProductAmount = info.ProductAmount,
                                       ProductDetail = info.ProductDetail,
                                       ProductPrice = price.ProductPrice,
                                       ProductCalPrice = price.ProductCalPrice
                                   };

                // Datagrid'e veriyi yükle
                dataGridView1.DataSource = combinedData.ToList();

                // Datagrid'i yenile
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void Form3_Load(object sender, EventArgs e)
        {
            await RefreshDataGrid(); // Form yüklendiğinde datagrid'i güncelle
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await RefreshDataGrid(); // Listele butonuna basıldığında datagrid'i güncelle
        }






        //// Filtreleme butonuna tıklandığında çalışacak metod
        //private async void btnFilter_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter();
        //}

        //// Filtreleme işlemini gerçekleştiren metod
        //// Filtreleme işlemini gerçekleştiren metod
        //private void ApplyFilter()
        //{
        //    // TextBox'lardaki filtre değerlerini alın
        //    string id = txtFilterID.Text;
        //    string amount = txtFilterAmount.Text;
        //    string name = txtFilterName.Text;
        //    string price = txtFilterPrice.Text;

        //    // Filtreleme için bir expression oluşturun
        //    Expression<Func<PricetaxDto, bool>> filterExpression = p =>
        //        (string.IsNullOrEmpty(id) || p.ProductID.ToString().Contains(id)) &&
        //        (string.IsNullOrEmpty(price) || (p.ProductCalPrice).ToString().Contains(price));

        //    // Ürün listesini filtreleyin
        //    var filteredProducts = products.AsQueryable().Where(filterExpression).ToList();

        //    // Datagrid'e filtrelenmiş ürünleri yükle
        //    dataGridView1.DataSource = filteredProducts;

        //    // Datagrid'i yenile
        //    dataGridView1.Refresh();
        //}
    }
}


