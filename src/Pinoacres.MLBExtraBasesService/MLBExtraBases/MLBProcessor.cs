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
            bool keepRunning = true;
            int checkIntervalMinutes = 5;
            DateTime processingTime = DateTime.Now;

            var startEmail = api.MailLogic.CreateMLBStartupEmail("");
            api.MailLogic.SendEmail(startEmail);

            while (keepRunning)
            {
                if (processingTime < DateTime.Now)
                {
                    var games = api.MLBExtraBasesLogic.GetTicketDataForSeason(DateTime.Today);

                    if (games.Count > 0)
                    {
                        List<MLBExtraBasesTicketData> ticketDataList = new List<MLBExtraBasesTicketData>();

                        foreach (RootObject game in games)
                        {
                            MLBExtraBasesTicketData ticketData = new MLBExtraBasesTicketData(game);
                            ticketDataList.Add(ticketData);
                        }

                        var ticketsAvailbleEmail = api.MailLogic.CreateMLBTicketsAvailableEmail("", ticketDataList);
                        api.MailLogic.SendEmail(ticketsAvailbleEmail);
                    }

                    processingTime = processingTime.AddMinutes(checkIntervalMinutes);
                }
            }            
        }
    }
}
