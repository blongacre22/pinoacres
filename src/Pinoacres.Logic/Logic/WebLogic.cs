using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Pinoacres.Logic
{
    public class WebLogic
    {
        public static string GetJsonResponseString(string url)
        {
            HttpWebRequest request = WebRequest.CreateHttp(url);
            var responseTask = request.GetResponseAsync();
            var response = responseTask.Result;
            var stream = response.GetResponseStream();
            var sr = new System.IO.StreamReader(stream);
            var json = sr.ReadToEnd();

            return json;
        }

        public static string UrlBuilder(params object[] urlParts)
        {
            StringBuilder url = new StringBuilder();

            for (int i = 0; i < urlParts.Length; i++)
            {
                url.Append(urlParts[i]);

                if (i != (urlParts.Length - 1))
                {
                    url.Append("/");
                }

            }

            return url.ToString(); ;
        }
    }
}
