using RestWithASP_NET5.API.Data.VO;
using System.Collections.Generic;

namespace RestWithASP_NET5.API.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}
