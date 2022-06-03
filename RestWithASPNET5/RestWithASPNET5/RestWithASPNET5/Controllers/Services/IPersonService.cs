using RestWithASPNET5.Controllers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNET5.Controllers.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
