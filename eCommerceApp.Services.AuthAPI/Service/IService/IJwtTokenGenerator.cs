using eCommerceApp.Services.AuthAPI.Models;

namespace eCommerceApp.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        public string GenerateJwtToken(ApplicationUser applicationUser);
    }
}
