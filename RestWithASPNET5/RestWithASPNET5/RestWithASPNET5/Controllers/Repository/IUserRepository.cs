using RestWithASPNET5.Controllers.Model;
using RestWithASPNET5.Data.VO;

namespace RestWithASPNET5.Controllers.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);

        User RefreshUserInfo(User user);
    }
}
