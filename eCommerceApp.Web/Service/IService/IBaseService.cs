using eCommerceApp.Web.Models;

namespace eCommerceApp.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
