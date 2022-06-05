using RestWithASPNET5.Controllers.Model;
using System.Collections.Generic;

namespace RestWithASPNET5.Controllers.Repository
{
    public interface IBooksRepository
    {
        Books Create(Books book);
        Books FindByID(long id);
        List<Books> FindAll();
        Books Update(Books book);
        void Delete(long id);
        bool Exists(long id);
    }
}
