using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pinoacres.Web.UI.Controllers
{
    public class MothersDayController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}