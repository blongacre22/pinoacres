using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Pinoacres.Web.UI.Controllers
{
    public class MothersDayController : Controller
    {
        // TODO: Replace with "appsettings.json" settings
        private string defaultYear = "2016";

        public IActionResult Home(string id)
        {
            this.SetViewDataYear(id);
            return View();
        }

        public IActionResult Notes(string id)
        {
            this.SetViewDataYear(id);
            return View();
        }

        public IActionResult Pictures(string id)
        {
            this.SetViewDataYear(id);
            return View();
        }

        public IActionResult Videos(string id)
        {
            this.SetViewDataYear(id);
            return View();
        }

        private void SetViewDataYear(string id)
        {
            this.ViewData["Year"] = id ?? defaultYear;
        }
    }
}