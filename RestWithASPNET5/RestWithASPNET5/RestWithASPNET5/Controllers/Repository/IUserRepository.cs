using RestWithASPNET5.Controllers.Model;
using RestWithASPNET5.Data.VO;

namespace RestWithASPNET5.Controllers.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);

        User ValidateCredentials(string userName);

        bool RevokeToken(string userName);

        User RefreshUserInfo(User user);
    }
}
