﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace TeamService
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
            .AddCommandLine(args)
            .Build();

            var host = new WebHostBuilder()
            .UseKestrel()
            .UseStartup<Startup>()
            .UseConfiguration(config)
            .Build();

            host.Run();
        }
    }
}
