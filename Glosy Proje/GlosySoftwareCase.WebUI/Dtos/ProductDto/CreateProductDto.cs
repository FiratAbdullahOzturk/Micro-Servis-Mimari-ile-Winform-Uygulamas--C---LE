namespace GlosySoftwareCase.WebUI.Dtos.ProductDto
{
    public class CreateProductDto
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductAmount { get; set; }
        public string ProductDetail { get; set; }
    }
}
