using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pinoacres.DataAccessLayer
{
    public class DALC
    {
        public DALC()
        {
            MLBExtraBasesDALC = new MLBExtraBasesDALC();
        }

        public MLBExtraBasesDALC MLBExtraBasesDALC { get; set; }
        public RPSLSDALC RPSLSDALC { get; set; }
    }
}
