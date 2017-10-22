using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PersonAPI.Model;

namespace PersonAPI.Controllers
{
    [Route("api/Persons")]
    public class PersonsController : Controller
    {
        [HttpGet()]
        public IActionResult GetPersons()
        {
            var persons = new List<PersonDto>()
            {
                new PersonDto(1, "Gert", "de Tant"),
                new PersonDto(2, "Ilse", "Bekaert")
            };

            return Ok(persons);
        }

    }
}
