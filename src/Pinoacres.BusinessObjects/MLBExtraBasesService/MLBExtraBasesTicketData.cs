using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pinoacres.BusinessObjects
{
    public class MLBExtraBasesTicketData
    {
        public MLBExtraBasesTicketData()
        {
        }

        public MLBExtraBasesTicketData(RootObject game)
        {
            if (game != null)
            {
                Cstm details = game.cstms[0] ?? new Cstm();
                Opponent = game.away_team;
                Date = DateTime.Parse(game.game_date + " " + game.game_time);
                TicketStatus = game.status;
                Price = details.unit_price.ToInt();
                TicketLevel = details.tix_level;
                TicketSection = details.tix_section;
                TicketRow = details.tix_row;
                Description = details.description;
                IsExpired = details.is_expired.ToBool();
            }            
        }

        public string Opponent { get; set; }
        public DateTime Date { get; set; }
        public string TicketStatus { get; set; }
        public int Price { get; set; }
        public string TicketLevel { get; set; }
        public string TicketSection { get; set; }
        public string TicketRow { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public bool IsExpired { get; set; }
    }
}
