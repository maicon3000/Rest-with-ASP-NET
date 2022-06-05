using RestWithASPNET5.Controllers.Model;
using RestWithASPNET5.Controllers.Model.Context;
using RestWithASPNET5.Controllers.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNET5.Controllers.Business.Implementations
{
    public class BooksBusinessImplementation : IBooksBusiness
    {
        private readonly IBooksRepository _repository;

        public BooksBusinessImplementation(IBooksRepository reprository)
        {
            _repository = reprository;
        }

        public List<Books> FindAll()
        {
            return _repository.FindAll();
        }

        public Books FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public Books Create(Books book)
        {
            return _repository.Create(book);
        }

        public Books Update(Books book)
        {
            return _repository.Update(book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
