using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace hello_world_api.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        // GET api/helllo
        [HttpGet]
        public string Get()
        {
            return "Hello world!!!!!!";
        }

    }
}
