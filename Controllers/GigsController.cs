using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NinneHomePage.Controllers
{
    public class GigsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Past()
        {
            return View();
        }

        public IActionResult Upcomming()
        {
            return View();
        }
    }
}