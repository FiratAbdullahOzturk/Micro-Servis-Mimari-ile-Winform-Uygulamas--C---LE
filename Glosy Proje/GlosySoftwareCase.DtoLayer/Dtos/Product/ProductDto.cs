using GlosySoftwareCase.EntityLayer.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlosySoftwareCase.DtoLayer.Dtos.Product
{
    [NotMapped]
    public class ProductDto_List : Base
    {
        public string ProductName { get; set; }
        public int ProductAmount { get; set; }
        public string ProductDetail { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductCalPrice { get; set; }

    }
}

 