using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Pinoacres.BusinessObjects;

namespace Pinoacres.Logic
{
    public class MLBExtraBasesLogic
    {
        public bool CheckForTickets(DateTime cutoffDate)
        {
            bool keepRunning = true;
            bool processMoreDates = true;
            DateTime dateToCheck = cutoffDate;

            while (processMoreDates)
            {
                MLBDataRequest data = new MLBDataRequest()
                {
                    CalendarView = MLBUrlParts.ViewGameCalendar,
                    CategoryCode = MLBUrlParts.BofATickets,
                    Date = cutoffDate,
                    Language = MLBUrlParts.English,
                    TeamCode = MLBUrlParts.TeamCode_SFN
                };

                string url = BuildMLBExtraBasesUrl(data);







                dateToCheck = dateToCheck.AddDays(1);

                if (dateToCheck.IsLastDayOfYear())
                {
                    processMoreDates = false;
                }
            }

            return keepRunning;
        }

        public void GetTicketDataForDate(DateTime date)
        {

        }

        public string BuildMLBExtraBasesUrl(MLBDataRequest data)
        {
            return WebLogic.UrlBuilder(MLBUrlParts.BaseUrl, MLBUrlParts.PubAjaxWs, MLBUrlParts.BamRest, MLBUrlParts.Product, MLBUrlParts.Version_01_01, data.ToDataRequestString());
        }
    }
}
