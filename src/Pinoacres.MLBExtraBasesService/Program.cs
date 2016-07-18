using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Pinoacres.BusinessObjects;
using Pinoacres.Logic;

namespace Pinoacres.MLBExtraBasesService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting MLB Pinger application.");
            MLBProcessor mlb = new MLBProcessor();
            mlb.Run();
        }
    }
}
