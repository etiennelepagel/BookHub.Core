using System;
using System.Collections.Generic;
using Google.Cloud.Functions.Framework;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Google.Cloud.Functions.Hosting;

namespace BookHub.Core.Appointment;

[FunctionsStartup(typeof(Startup))]
public class Function : IHttpFunction
{
    /// <summary>
    /// Logic for your function goes here.
    /// </summary>
    /// <param name="context">The HTTP context, containing the request and the response.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task HandleAsync(HttpContext context)
    {
        await context.Response.WriteAsync("Hello, Functions Framework.");
    }
}