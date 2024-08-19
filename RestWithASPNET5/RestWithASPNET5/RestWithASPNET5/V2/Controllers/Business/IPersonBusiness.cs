using RestWithASPNET5.Hypermedia.Utils;
using RestWithASPNET5.V2.Data.VO;
using System.Collections.Generic;

namespace RestWithASPNET5.V2.Controllers.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);

        PersonVO FindByID(long id);

        List<PersonVO> FindAll();

        PagedSearchVO<PersonVO> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page);

        PersonVO Update(PersonVO person);
        
        PersonVO Disable(long id);

        void Delete(long id);
    }
}
