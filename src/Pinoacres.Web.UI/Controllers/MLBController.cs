using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Pinoacres.BusinessObjects;
using Pinoacres.Logic;

namespace Pinoacres.Web.UI.Controllers
{
    public class MLBController : BasePinoacresController
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Are you tired of checking back to see if tickets are available?";

            MLBExtraBasesTicketData ticketData = API.MLBExtraBasesLogic.GetTicketDataForDate(DateTime.Today);

            return View();
        }
    }
}
