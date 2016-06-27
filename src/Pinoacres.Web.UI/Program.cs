using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace Pinoacres.Web.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] urls = new string[] { "http://localhost:80", "http://0.0.0.0:80" };

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                // May need to add "UseUrls" method here
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
