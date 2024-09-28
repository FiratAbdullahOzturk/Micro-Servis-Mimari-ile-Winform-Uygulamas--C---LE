using GlosySoftwareCase.WebUI.Dtos.ProductDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace GlosySoftwareCase.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7171/api/Products");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createProductDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7171/api/Products", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7171/api/Products/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7171/api/Products/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateProductDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateProductDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7171/api/Products/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

public enum Color
{
    Red = 1,
    White = 2,
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Color Color { get; set; }

    public Category Category { get; set; }
}

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Product> Products { get; set; }
}

public class Case
{

    public List<Product> ProductList = new();
    public List<Category> CategoryList = new();

    public void CaseMethod()
    {
        //Ürün listesi üzerinde Regi Red olan ürünlerin listesi. (ProductList üzerinden)
        List<Product> rengiRedOlanUrunler = ProductList.Where(x => x.Color == Color.Red).ToList();

        //Ürün listesinde ismi "Buz Dolabı" olan ürünlerin listesi. (ProductList üzerinden)
        List<Product> productBuzDolabi = ProductList.Where(x => x.Name.Equals("Buz Dolabı")).ToList();

        //Ürün listesinde ismi "Buz" ile başlayan ürünlerin listesi. (ProductList üzerinden)
        List<Product> productBuz = ProductList.Where(x => x.Name.StartsWith("Buz")).ToList();

        //Ürün listesinde categry ismi "Beyaz Eşya" olan ürünlerin listesi. (ProductList üzerinden)
        List<Product> categoryIsmiBeyazEsyaOlanUrunler = ProductList.Where(x => x.Category.Name == "Beyaz eşya").ToList();

        //Category listesindeki ürünlerden rengi kırmızı olan categorylerin listesi. (CategoryList üzerinden)
        List<Category> rengiRedOlanUrunlerOnCategory = CategoryList.Where(x => x.Products.Any(p => p.Color == Color.Red)).ToList();

        //Category listesinde isminde "Buz" ifadesi içeren ürünlerin listesi. (CategoryList üzerinden)
        List<Product> productList = CategoryList.Where(x => x.Products.Any(p => p.Name.Contains("Buz"))).SelectMany(x => x.Products).ToList();

        //Product Listesinin idsi tek sayı olan ürünlerin listesi.
        List<Product> productTekSayi = ProductList.Where(x => x.Id % 2 != 0).ToList();
    }
}




