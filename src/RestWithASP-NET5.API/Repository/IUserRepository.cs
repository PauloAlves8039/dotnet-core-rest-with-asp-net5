using RestWithASP_NET5.API.Data.VO;
using RestWithASP_NET5.API.Model;

namespace RestWithASP_NET5.API.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
    }
}
