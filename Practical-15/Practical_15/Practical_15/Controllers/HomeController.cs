using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_15.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public HomeController(ILogger<HomeController> logger)
        {
            Logger = logger;
        }

        public ILogger<HomeController> Logger { get; }

        [HttpGet]
        public string Index()
        {
            Logger.LogInformation(">>>>>>>Called index action<<<<<<<");
            return "Hello World!!!";
        }
    }
}
