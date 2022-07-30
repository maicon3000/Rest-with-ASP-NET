using RestWithASPNET5.Controllers.Model;

namespace RestWithASPNET5.Controllers.Repository
{
    interface IUserRepository
    {
        User ValidationsCredentials(UserVO user);
    }
}
