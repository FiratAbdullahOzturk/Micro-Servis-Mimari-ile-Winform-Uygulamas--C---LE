using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlosySoftwareCase.EntityLayer.Concrete
{
    public class ProductCPrice : Base
    {
        [Key, ForeignKey("ProductInfo")]
        public new int Id { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductCalPrice { get; set; }

        // Navigation property for reverse reference
        public ProductInfo ProductInfo { get; set; }
    }
}