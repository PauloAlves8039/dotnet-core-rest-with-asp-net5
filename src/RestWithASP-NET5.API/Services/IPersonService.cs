using RestWithASP_NET5.API.Model;
using System.Collections.Generic;

namespace RestWithASP_NET5.API.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
