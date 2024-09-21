using CustomAuthFilter.Models;

namespace CustomAuthFilter.Repositories.Interfaces
{
    public interface IProductRepo
    {
        List<Product> GetAll();
    }
}
