using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstVueTutorial.Controllers
{
    [Produces("application/json")]
    [Route("api/Hello")]
    public class HelloController : Controller
    {
        [Route("add/{a}/{b}")]
        public IActionResult Add(int a, int b)
        {
            return Ok(a + b);
        }
    }
}