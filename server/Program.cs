using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using server.Services.Http;

namespace larry_backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var x =HttpUtility.sendGet("https://swapi.co/api/people/1/");

            BuildWebHost(args).Run();

            

            Console.WriteLine(x);
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
