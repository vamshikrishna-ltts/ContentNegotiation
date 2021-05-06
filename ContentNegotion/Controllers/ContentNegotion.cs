using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ContentNegotion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContentNegotion : ControllerBase
    {
       
        private static readonly string[] Names = new[]
        {
            "Freezing", "Bracing", "Chilly", 
            "Cool", "Mild", "Warm", "Balmy", "Hot", 
            "Sweltering", "Scorching"
        };

        //Get: api/ContentNegotion
        //returns content-type = json format
        [Route("api/[controller]")]
        [HttpGet]
        public IActionResult GetNames()
        {
            return Ok(Names);
        }

        //Get: api/ContentNegotion/string
        //returns content-type = text/plain;
        [Route("api/[controller]/{stringName}")]
        [HttpGet]
        public IActionResult userEnteredString(string name)
        {
            return Ok(name);
        }

        // GET: api/authors/search?namelike=th
        [HttpGet("Search")]
        public IActionResult Search(string namelike)
        {
            var result = Names.Contains(namelike);
            if (!result)
            {
                return NotFound(namelike);
            }
            return Ok(namelike);
        }
    }
}
