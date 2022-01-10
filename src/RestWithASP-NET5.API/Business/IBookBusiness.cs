using RestWithASP_NET5.API.Data.VO;
using RestWithASP_NET5.API.Hypermedia.Utils;
using System.Collections.Generic;

namespace RestWithASP_NET5.API.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        PagedSearchVO<BookVO> FindWithPagedSearch(string title, string sortDirection, int pageSize, int page);
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}
