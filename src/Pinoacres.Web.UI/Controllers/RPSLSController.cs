using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pinoacres.Web.UI.Controllers
{
    public class RPSLSController : BasePinoacresController
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "As seen on TV!";

            API.RPSLSLogic.GetGameResult();

            return View();
        }
    }
}
