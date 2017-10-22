using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PersonAPI.Controllers
{
    [Route("api/Persons")]
    public class PersonsController : Controller
    {
        public IActionResult GetPersons()
        {

            return Ok();
        }

    }
}
