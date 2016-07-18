using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pinoacres.BusinessObjects
{
    public class RootObject
    {
        public long id { get; set; }
        public string game_time { get; set; }
        public string status { get; set; }
        public string game_date { get; set; }
        public string away_team { get; set; }
        public string home_team { get; set; }
        public List<Cstm> cstms { get; set; }
    }
}
