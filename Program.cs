using System;
using System.Net;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.ApplicationInsights;

namespace Kamall_foods_server_aspNetCore;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                //webBuilder.UseStartup<Startup>();

                webBuilder.UseStartup<Startup>().ConfigureKestrel(options =>
                {
                    var port = 5001;
                    var pfxFilePath = "./conf.d/https/kamall-foods-server.xyz.pfx";
                    // The password you specified when exporting the PFX file using OpenSSL.
                    // This would normally be stored in configuration or an environment variable;
                    // I've hard-coded it here just to make it easier to see what's going on.
                    var pfxPassword = Environment.GetEnvironmentVariable("PFXPASSWORD");

                    options.Listen(IPAddress.Any, port, listenOptions =>
                    {
                        // Enable support for HTTP1 and HTTP2 (required if you want to host gRPC endpoints)
                        listenOptions.Protocols = HttpProtocols.Http1AndHttp2;
                        // Configure Kestrel to use a certificate from a local .PFX file for hosting HTTPS
                        listenOptions.UseHttps(pfxFilePath, pfxPassword);
                    });
                });
            });
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args)
    {
        return WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .ConfigureLogging(logging =>
            {
                logging.AddApplicationInsights("KamallFoodsServer");
                logging.AddFilter<ApplicationInsightsLoggerProvider>("", LogLevel.Trace);
            });
    }
}