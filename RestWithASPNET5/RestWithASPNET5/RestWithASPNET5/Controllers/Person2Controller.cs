using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNET5.Controllers.Business;
using RestWithASPNET5.Data.VO;
using RestWithASPNET5.Hypermedia.Filters;

namespace RestWithASPNET5.Controllers
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route("api/person/v{version:apiVersion}")]
    public class Person2Controller : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private IPersonBusiness _personBusiness;
        public Person2Controller(ILogger<PersonController> logger, IPersonBusiness personService)
        {
            _logger = logger;
            _personBusiness = personService;
        }

        [HttpGet]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_personBusiness.FindAll());
        }
        
        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var person = _personBusiness.FindByID(id);
            if(person == null) return NotFound();
            return Ok(person);
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] PersonVO person)
        {
            if (person == null || person.BirthDate == null) return BadRequest("Error: It is necessary to inform the BirthDate field");
            return Ok(_personBusiness.Create(person));
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] PersonVO person)
        {
            if (person == null) return BadRequest();
            return Ok(_personBusiness.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personBusiness.Delete(id);
            return NoContent();
        }
    }
}
