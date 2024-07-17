using CustomAuthorizeFilter.Models;

namespace CustomAuthorizeFilter.Repositories.Interface
{
    public interface IProductRepo
    {
        List<Product> GetAll();
    }
}
