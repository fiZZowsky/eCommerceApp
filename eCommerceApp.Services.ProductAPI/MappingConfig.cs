using AutoMapper;
using eCommerceApp.Services.ProductAPI.Models;
using eCommerceApp.Services.ProductAPI.Models.Dto;

namespace eCommerceApp.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
