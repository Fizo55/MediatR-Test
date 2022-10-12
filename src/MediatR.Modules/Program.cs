using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MediatR.Modules;

internal static class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            await BuildHost(args).RunAsync().ConfigureAwait(false);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static IWebHost BuildHost(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build();
}