using GlosySoftwareCase.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlosySoftwareCase.DtoLayer.Dtos.ProductDto
{
    public class ResultProductDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductAmount { get; set; }
        public string ProductDetail { get; set; }
        public decimal ProductCalPrice { get { return ProductPrice * 1.20m; } }    
    }
}
