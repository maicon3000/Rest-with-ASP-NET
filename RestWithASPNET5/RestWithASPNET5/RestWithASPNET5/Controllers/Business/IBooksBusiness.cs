using RestWithASPNET5.Controllers.Model;
using System.Collections.Generic;

namespace RestWithASPNET5.Controllers.Business
{
    public interface IBooksBusiness
    {
        Books Create(Books book);
        Books FindByID(long id);
        List<Books> FindAll();
        Books Update(Books book);
        void Delete(long id);
    }
}
