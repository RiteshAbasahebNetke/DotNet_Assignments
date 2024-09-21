using CustomAuthFilter.Models;
using CustomAuthFilter.ViewModels;

namespace CustomAuthFilter.Repositories.Interfaces
{
    public interface IUserRepo
    {
        LoginResultVM Login(LoginVM rec);
        void Register(User rec);
    }
}
