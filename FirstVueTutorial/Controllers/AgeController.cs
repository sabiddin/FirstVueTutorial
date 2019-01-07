using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstVueTutorial.Controllers
{
    [Produces("application/json")]
    [Route("api/Age")]
    public class AgeController : Controller
    {
        [Route("getAge/{date}")]
        public IActionResult GetAge(string date)
        {
            DateTime dob = Convert.ToDateTime(date);
            var diff = DateTime.Now.Year - dob.Year;
            return Ok($"You are {diff} years old");
        }
    }
}