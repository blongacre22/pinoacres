using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Pinoacres.BusinessObjects;
using Pinoacres.Logic;

namespace Pinoacres.MLBExtraBasesService
{
    public class MLBProcessor
    {
        private static API api = new API();

        public void Run()
        {
            bool keepRunning = false;

            while (keepRunning)
            {
                keepRunning = api.MLBExtraBasesLogic.CheckForTickets(DateTime.Today);
            }            
        }
    }
}
