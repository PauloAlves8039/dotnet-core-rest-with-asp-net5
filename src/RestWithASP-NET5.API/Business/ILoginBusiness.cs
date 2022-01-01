using RestWithASP_NET5.API.Data.VO;

namespace RestWithASP_NET5.API.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidateCredentials(UserVO user);
    }
}
