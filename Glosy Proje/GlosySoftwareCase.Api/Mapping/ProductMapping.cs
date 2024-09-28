using AutoMapper;
using GlosySoftwareCase.DtoLayer.Dtos.ProductDto;
using GlosySoftwareCase.DtoLayer.Dtos.Product;
using GlosySoftwareCase.EntityLayer.Concrete;

namespace GlosySoftwareCase.Api.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping()
        {          

            CreateMap<ResultProductDto, ProductDto_List>().ReverseMap();
            CreateMap<CreateProductDto, ProductDto_List>().ReverseMap();
            CreateMap<UpdateProductDto, ProductDto_List>().ReverseMap();
            CreateMap<ProductInfo, ProductDto_List>()
                .ForMember(dto => dto.ProductName, opt => opt.MapFrom(pi => pi.ProductName))
                .ForMember(dto => dto.ProductAmount, opt => opt.MapFrom(pi => pi.ProductAmount))
                .ForMember(dto => dto.ProductDetail, opt => opt.MapFrom(pi => pi.ProductDetail))
                .ForMember(dto => dto.ProductPrice, opt => opt.MapFrom(pi => pi.ProductCPrice.ProductPrice))
                .ForMember(dto => dto.ProductCalPrice, opt => opt.MapFrom(pi => pi.ProductCPrice.ProductCalPrice))
                .ForMember(dto => dto.Id, opt => opt.MapFrom(pi => pi.Id));

            CreateMap<ProductDto_List, ProductInfo>()
                .ForMember(pi => pi.ProductName, opt => opt.MapFrom(dto => dto.ProductName))
                .ForMember(pi => pi.ProductAmount, opt => opt.MapFrom(dto => dto.ProductAmount))
                .ForMember(pi => pi.ProductDetail, opt => opt.MapFrom(dto => dto.ProductDetail))
                .ForMember(pi => pi.ProductCPrice, opt => opt.Ignore());

        }
    }
}
