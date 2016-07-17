using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Net.Http;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Pinoacres.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Console app MAIN program.");
            Lib.TestClass.TestMethod();

            string url = "http://www.mlbextrabases.com/pubajaxws/bamrest/product/v-1.1?catCode=BOA_TICKETS-sfn-08-2016&lang=en&view=game_cal";
            //var contents = new System.Net.WebClient().DownloadString(url);
            HttpWebRequest request = WebRequest.CreateHttp(url);
            var responseTask = request.GetResponseAsync();
            var response = responseTask.Result;
            var stream = response.GetResponseStream();
            var sr = new System.IO.StreamReader(stream);
            var json = sr.ReadToEnd();

            json = json.Replace("var products = ", string.Empty);

            var objects = JsonConvert.DeserializeObject(json);
        }
    }
}
