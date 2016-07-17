using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pinoacres.Logic
{
    public class API
    {
        public API()
        {
            this.MailLogic = new MailLogic();
            this.MLBExtraBasesLogic = new MLBExtraBasesLogic();
            this.WebLogic = new WebLogic();
        }

        public MailLogic MailLogic { get; set; }
        public MLBExtraBasesLogic MLBExtraBasesLogic { get; set; }
        public WebLogic WebLogic { get; set; }
    }
}
