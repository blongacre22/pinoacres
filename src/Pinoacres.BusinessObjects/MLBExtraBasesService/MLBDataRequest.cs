using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinoacres.BusinessObjects
{
    public class MLBDataRequest
    {
        public string CategoryCode { get; set; }
        public string TeamCode { get; set; }
        public DateTime Date { get; set; }
        public string Language { get; set; }
        public string CalendarView { get; set; }

        public string MonthYear
        {
            get
            {
                return Date.ToString("MM-yyyy");
            }
        }

        public string ToDataRequestString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("?");
            sb.Append(MLBUrlParts.CategoryCode);
            sb.Append("=");
            sb.Append(this.CategoryCode);
            sb.Append("-");
            sb.Append(this.TeamCode);
            sb.Append("-");
            sb.Append(this.MonthYear);
            sb.Append("&");
            sb.Append(MLBUrlParts.Language);
            sb.Append("=");
            sb.Append(this.Language);
            sb.Append("&");
            sb.Append(MLBUrlParts.View);
            sb.Append("=");
            sb.Append(this.CalendarView);

            return sb.ToString();
        }
    }
}
