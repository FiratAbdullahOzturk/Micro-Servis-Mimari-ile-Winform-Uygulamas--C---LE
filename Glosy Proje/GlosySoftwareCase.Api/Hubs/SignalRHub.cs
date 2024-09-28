using GlosySoftwareCase.BusinessLayer.Abstract;
using GlosySoftwareCase.DtoLayer.Dtos.Product;
using GlosySoftwareCase.EntityLayer.Concrete;
using Microsoft.AspNetCore.SignalR;

namespace GlosySoftwareCase.Api.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly IGenericService<ProductDto_List> _productService;

        public SignalRHub(IGenericService<ProductDto_List> productService)
        {
            _productService = productService;
        }
       
        public async Task GetProductTable()
        {
            var values = await _productService.TGetListAsync();
            await Clients.All.SendAsync("ReceiveProductList", values);
        }
    }
}
