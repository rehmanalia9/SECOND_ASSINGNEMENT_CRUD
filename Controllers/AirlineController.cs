using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SecondAssingnment.Controllers
{
    public class AirlineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}