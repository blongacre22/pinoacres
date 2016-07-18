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
            AppConfigurationLogic = new AppConfigurationLogic();
            MailLogic = new MailLogic();
            MLBExtraBasesLogic = new MLBExtraBasesLogic();
            RPSLSLogic = new RPSLSLogic();
            WebLogic = new WebLogic();
        }

        public AppConfigurationLogic AppConfigurationLogic { get; set; }
        public MailLogic MailLogic { get; set; }
        public MLBExtraBasesLogic MLBExtraBasesLogic { get; set; }
        public RPSLSLogic RPSLSLogic { get; set; }
        public WebLogic WebLogic { get; set; }
    }
}
