using RestWithASP_NET5.API.Model;
using RestWithASP_NET5.API.Repository.Generic;

namespace RestWithASP_NET5.API.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);
    }
}
