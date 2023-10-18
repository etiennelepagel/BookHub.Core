using BookHub.Core.Application;
using BookHub.Core.Persistence;
using Google.Cloud.Functions.Hosting;
using Google.LongRunning;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BookHub.Core.Appointment;

public class Startup : FunctionsStartup
{
    public override void ConfigureServices(WebHostBuilderContext context, IServiceCollection services)
    {
        services.AddSingleton<IBusinessRepository, BusinessRepository>();
    }
}