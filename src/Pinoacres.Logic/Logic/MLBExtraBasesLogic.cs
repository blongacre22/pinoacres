using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft;
using Newtonsoft.Json;

using Pinoacres.BusinessObjects;

namespace Pinoacres.Logic
{
    public class MLBExtraBasesLogic
    {
        public bool CheckForTickets(DateTime cutoffDate)
        {
            bool keepRunning = true;
            
            List<RootObject> games = new List<RootObject>();
            games = GetTicketDataForSeason(cutoffDate);
                        
            return keepRunning;
        }

        public MLBExtraBasesTicketData GetTicketDataForDate(DateTime date)
        {
            MLBDataRequest data = BuildMLBDataRequest(date);
            List<RootObject> gamesForMonth = GetGamesForMonth(data);
            RootObject game = gamesForMonth.FirstOrDefault(f => f.game_date == date.ToString("MM/dd/yyyy"));

            MLBExtraBasesTicketData ticketData = new MLBExtraBasesTicketData(game);
            
            return ticketData;
        }

        public bool AreAnyTicketsAvailableForRestOfSeason(DateTime cutoffDate)
        {
            return false;
        }

        public List<RootObject> GetTicketDataForSeason(DateTime cutoffDate)
        {
            bool processMoreDates = true;
            List<RootObject> games = new List<RootObject>();
            DateTime date = cutoffDate;

            while (processMoreDates)
            {
                date = date.SetToFirstOfTheMonth();
                MLBDataRequest data = BuildMLBDataRequest(date);

                List<RootObject> gamesForMonth = GetGamesForMonth(data);

                if (gamesForMonth.Count > 0)
                {
                    games.AddRange(gamesForMonth);
                }

                date = date.AddMonths(1);

                // Baseball season ends in November (11). Technically, last regular season game is in October (10).
                if (date.Month >= 12)
                {
                    processMoreDates = false;
                }
            }

            return games;
        }

        public List<RootObject> GetGamesForMonth(MLBDataRequest data)
        {
            string url = BuildMLBExtraBasesUrl(data);
            string jsonResponse = WebLogic.GetJsonResponseString(url).Replace("var products = ", "");

            List<RootObject> gamesForMonth = JsonConvert.DeserializeObject<List<RootObject>>(jsonResponse);

            return gamesForMonth;
        }

        public string BuildMLBExtraBasesUrl(MLBDataRequest data)
        {
            return WebLogic.UrlBuilder(MLBUrlParts.BaseUrl, MLBUrlParts.PubAjaxWs, MLBUrlParts.BamRest, MLBUrlParts.Product, MLBUrlParts.Version_01_01) + data.ToDataRequestString();
        }

        public MLBDataRequest BuildMLBDataRequest(DateTime date)
        {
            MLBDataRequest data = new MLBDataRequest()
            {
                CalendarView = MLBUrlParts.ViewGameCalendar,
                CategoryCode = MLBUrlParts.BofATickets,
                Date = date,
                Language = MLBUrlParts.English,
                TeamCode = MLBUrlParts.TeamCode_SFN
            };

            return data;
        }
    }
}
