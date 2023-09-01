using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace NetCoreBaseline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // int workerThreads, portThreads;
            // ThreadPool.GetMaxThreads(out workerThreads, out portThreads);
            // Console.WriteLine($"Maximum worker threads: {workerThreads}\nMaximum completion port threads: {portThreads}");

            // ThreadPool.SetMaxThreads(workerThreads, portThreads * 2);
            // ThreadPool.GetMaxThreads(out workerThreads, out portThreads);
            // Console.WriteLine($"Maximum worker threads: {workerThreads}\nMaximum completion port threads: {portThreads}");

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
