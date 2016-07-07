using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pinoacres.Web.UI.Controllers
{
    public class MLBController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Are you tired of checking back to see if tickets are available?";

            return View();
        }
    }
}
