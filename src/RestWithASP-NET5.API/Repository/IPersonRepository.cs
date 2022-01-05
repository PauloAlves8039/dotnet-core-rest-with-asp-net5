using RestWithASP_NET5.API.Model;
using RestWithASP_NET5.API.Repository.Generic;
using System.Collections.Generic;

namespace RestWithASP_NET5.API.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);

        List<Person> FindByName(string firstName, string secondName);
    }
}
