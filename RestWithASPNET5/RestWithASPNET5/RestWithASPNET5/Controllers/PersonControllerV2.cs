using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNET5.Controllers.Model;
using RestWithASPNET5.Controllers.Business;

namespace RestWithASPNET5.Controllers
{
    [ApiVersion("2")]
    [ApiController]
    [Route("api/person/v{version:apiVersion}")]
    public class PersonControllerV2 : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private IPersonBusiness _personBusiness;
        public PersonControllerV2(ILogger<PersonController> logger, IPersonBusiness personService)
        {
            _logger = logger;
            _personBusiness = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personBusiness.FindAll());
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personBusiness.FindByID(id);
            if(person == null) return NotFound();
            return Ok(person);
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null || person.BirthDate == null) return BadRequest("Error: It is necessary to inform the BirthDate field");
            return Ok(_personBusiness.Create(person));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
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
