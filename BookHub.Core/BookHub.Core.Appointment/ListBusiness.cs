using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookHub.Core.Application;
using Google.Cloud.Firestore;
using Google.Cloud.Functions.Framework;
using Google.Cloud.Functions.Hosting;
using Microsoft.AspNetCore.Http;

namespace BookHub.Core.Appointment;

[FunctionsStartup(typeof(Startup))]
public class ListBusiness : IHttpFunction
{
    private readonly IBusinessRepository _businessRepository;

    public ListBusiness(IBusinessRepository businessRepository)
    {
        _businessRepository = businessRepository;
    }

    public async Task HandleAsync(HttpContext context)
    {
        var result = await this._businessRepository.GetBusinesses();
        await context.Response.WriteAsJsonAsync(result);
    }
}