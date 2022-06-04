using RestWithASPNET5.Controllers.Model;
using System.Collections.Generic;

namespace RestWithASPNET5.Controllers.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
