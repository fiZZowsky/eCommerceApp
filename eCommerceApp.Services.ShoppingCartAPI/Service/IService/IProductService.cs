using eCommerceApp.Services.ShoppingCartAPI.Models.Dto;

namespace eCommerceApp.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
