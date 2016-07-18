using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Pinoacres.BusinessObjects;
using Pinoacres.Logic;

namespace Pinoacres.Web.UI.Controllers
{
    public class BasePinoacresController : Controller
    {
        public BasePinoacresController()
        {
            API = new API();
        }

        public API API { get; set; }
    }
}
