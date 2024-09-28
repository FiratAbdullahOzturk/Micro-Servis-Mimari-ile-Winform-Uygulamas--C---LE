using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlosySoftwareCase.EntityLayer.Concrete
{
    public class ProductInfo : Base
    {
        public string ProductName { get; set; }
        public int ProductAmount { get; set; }
        public string ProductDetail { get; set; }
        // Foreign key
        public int ProductCPriceId { get; set; }

        // Navigation property
        public ProductCPrice ProductCPrice { get; set; }
        
    }
}