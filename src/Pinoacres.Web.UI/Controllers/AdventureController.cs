using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pinoacres.Web.UI.Controllers
{
    public class AdventureController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Which direction will you walk?!";

            return View();
        }
    }
}
