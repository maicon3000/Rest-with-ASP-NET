using RestWithASPNET5.Controllers.Model;
using System.Collections.Generic;

namespace RestWithASPNET5.Controllers.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);

        List<Person> FindByName(string firstName, string lastName);
    }
}
