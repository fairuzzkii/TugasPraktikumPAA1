using Microsoft.AspNetCore.Mvc;
using TugasPraktikumPAA1.Models;

namespace TugasPraktikumPAA1.Controllers
{
    [ApiController] 
    [Route("api/person")] 
    public class PersonController : Controller
    {
        private readonly PersonContext _context = new PersonContext();

        
        [HttpGet]
        public ActionResult<List<Person>> ListPerson()
        {
            return Ok(_context.ListPerson());
        }

        
        [HttpGet("{id}")]
        public ActionResult<Person> GetPerson(int id)
        {
            var person = _context.GetPersonById(id);
            if (person == null)
            {
                return NotFound(new { message = "Data tidak dapat ditemukan" });
            }
            return Ok(person);
        }
    }
}
