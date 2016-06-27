using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pinoacres.Web.UI.Controllers
{
    public class MothersDayController : Controller
    {
        private string defaultYear = "2016";

        public IActionResult Home(string id)
        {
            this.ViewData["Year"] = id ?? defaultYear;
            return View();
        }

        public IActionResult Notes(string id)
        {
            this.ViewData["Year"] = id ?? defaultYear;
            return View();
        }

        public IActionResult Pictures(string id)
        {
            this.ViewData["Year"] = id ?? defaultYear;
            return View();
        }

        public IActionResult Videos(string id)
        {
            this.ViewData["Year"] = id ?? defaultYear;
            return View();
        }
    }
}