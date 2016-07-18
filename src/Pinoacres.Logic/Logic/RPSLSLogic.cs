using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft;
using Newtonsoft.Json;

using Pinoacres.BusinessObjects;
using Pinoacres.DataAccessLayer;

namespace Pinoacres.Logic
{
    public class RPSLSLogic
    {
        public RPSLSLogic()
        {
            dalc = new DALC();
        }

        private DALC dalc;

        public void GetGameResult()
        {
            dalc.RPSLSDALC.SaveGameResults();
        }
    }
}
