using eCommerceApp.Services.ShoppingCartAPI.Models.Dto;

namespace eCommerceApp.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
