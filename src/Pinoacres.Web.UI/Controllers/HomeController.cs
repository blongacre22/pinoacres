using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pinoacres.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Personal website of Bruce Longacre II";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact page for the Pinoacres website";

            return View();
        }

        public IActionResult Resume()
        {
            ViewData["Message"] = "Resume for Bruce Longacre II";

            return View();
        }

        public IActionResult Links()
        {
            ViewData["Message"] = "Links for family and friends";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
