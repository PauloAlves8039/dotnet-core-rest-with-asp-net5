using RestWithASP_NET5.API.Model;
using System.Collections.Generic;

namespace RestWithASP_NET5.API.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);
        Book FindById(long id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(long id);
    }
}
