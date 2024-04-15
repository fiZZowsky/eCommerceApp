using Microsoft.AspNetCore.Identity;

namespace eCommerceApp.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
