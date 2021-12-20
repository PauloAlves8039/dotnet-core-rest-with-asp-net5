using RestWithASP_NET5.API.Data.Converter.Implementations;
using RestWithASP_NET5.API.Data.VO;
using RestWithASP_NET5.API.Model;
using RestWithASP_NET5.API.Repository.Generic;
using System.Collections.Generic;

namespace RestWithASP_NET5.API.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IRepository<Book> _repository;
        private readonly BookConverter _converter;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        List<BookVO> IBookBusiness.FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        BookVO IBookBusiness.FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        BookVO IBookBusiness.Create(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Create(bookEntity);
            return _converter.Parse(bookEntity);
        }

        BookVO IBookBusiness.Update(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Update(bookEntity);
            return _converter.Parse(bookEntity);
        }

        void IBookBusiness.Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
