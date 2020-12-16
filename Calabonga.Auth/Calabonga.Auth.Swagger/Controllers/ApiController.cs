using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calabonga.DemoClasses;
using Microsoft.AspNetCore.Authorization;

namespace Calabonga.Auth.Swagger.Controllers
{
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private readonly List<Person> peoples = People.GetPeople();

        [HttpGet("[action]")]
        [Authorize]
        public IActionResult GetAll()
        {
            return Ok(peoples);
        }

        [HttpGet("[action]/{id:int}")]
        public IActionResult GetById(int id)
        {
            var item = peoples.FirstOrDefault(x => x.Id == id);
            return Ok(item);
        }
    }
}
