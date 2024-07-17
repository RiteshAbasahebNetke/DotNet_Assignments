using CustomAuthorizeFilter.Models;
using CustomAuthorizeFilter.ViewModel;

namespace CustomAuthorizeFilter.Repositories.Interface
{
    public interface IUserRepo
    {
        LoginResultVM Login(LoginVM rec);
        void Register(User rec);
    }
}
