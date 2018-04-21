using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace testApp.Controllers
{
    [Route("")]
    public class PlaneController : Controller
    {
        [Route("")] // Index is de default route
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[controller]/[action]")]
        public IActionResult Create()
        {
            return View();
        }
    }
}