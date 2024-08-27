using AutoMapper;
using eCommerceApp.Services.ShoppingCartAPI.Models;
using eCommerceApp.Services.ShoppingCartAPI.Models.Dto;

namespace eCommerceApp.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartHeaderDto, CartHeader>().ReverseMap();
                config.CreateMap<CartDetailsDto, CartDetails>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
