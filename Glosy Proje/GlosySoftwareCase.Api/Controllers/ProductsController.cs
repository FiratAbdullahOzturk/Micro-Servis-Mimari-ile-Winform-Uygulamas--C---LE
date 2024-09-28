using AutoMapper;
using GlosySoftwareCase.BusinessLayer.Abstract;
using GlosySoftwareCase.DtoLayer.Dtos.ProductDto;
using GlosySoftwareCase.DtoLayer.Dtos.Product;
using GlosySoftwareCase.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace GlosySoftwareCase.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IGenericService<ProductInfo> _productService;
        private readonly IMapper _mapper;

        public ProductsController(IGenericService<ProductInfo> productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            try
            {
                var values = await _productService.TGetAllProductsWithPrices();
                var resultValues = _mapper.Map<List<ProductDto_List>>(values);

                return Ok(resultValues);

            }
            catch (Exception ex)
            {
                throw;
            }
           
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _productService.TGetByIdAsync(id);
            return Ok(value);
        }

        //[HttpGet("find/{expression}")]
        //public async Task<IActionResult> Find(Expression<Func<ProductInfo, bool>> predicate)
        //{
        //    var value = await _productService.TFindAsync(predicate);
        //    return Ok(value);
        //}
        //[HttpPost]
        //public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        //{
        //    var newValue = _mapper.Map<ProductInfo>(createProductDto);
        //    await _productService.TCreateAsync(newValue);
        //    return Ok("Veri Başarıyla Eklendi");
        //}
        //[HttpPut]
        //public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        //{
        //    var updatedValue = _mapper.Map<ProductInfo>(updateProductDto);
        //    await _productService.TUpdateAsync(updatedValue);
        //    return Ok("Veri Başarıyla Güncellendi");
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCategory(int id)
        //{
        //    await _productService.TDeleteAsync(id);
        //    return Ok("Veri Başarıyla Silindi");
        //}
    }
}
