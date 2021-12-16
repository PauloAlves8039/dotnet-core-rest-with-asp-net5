﻿using RestWithASP_NET5.API.Model;
using RestWithASP_NET5.API.Repository;
using System.Collections.Generic;

namespace RestWithASP_NET5.API.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IBookRepository _repository;

        public BookBusinessImplementation(IBookRepository repository)
        {
            _repository = repository;
        }

        List<Book> IBookBusiness.FindAll()
        {
            return _repository.FindAll();
        }

        Book IBookBusiness.FindById(long id)
        {
            return _repository.FindById(id);
        }

        Book IBookBusiness.Create(Book book)
        {
            return _repository.Create(book);
        }

        Book IBookBusiness.Update(Book book)
        {
            return _repository.Update(book);
        }

        void IBookBusiness.Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}