using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Google.Cloud.Functions.Framework;
using Microsoft.AspNetCore.Http;

namespace BookHub.Core.Appointment;

public class ListBusiness : IHttpFunction
{
    /// <summary>
    /// Logic for your function goes here.
    /// </summary>
    /// <param name="context">The HTTP context, containing the request and the response.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task HandleAsync(HttpContext context)
    {
        var db = await FirestoreDb.CreateAsync();
        var docRef = db.Collection("users").Document("alovelace");
        var user = new Dictionary<string, object>
        {
            { "First", "Ada" },
            { "Last", "Lovelace" },
            { "Born", 1815 }
        };
        await docRef.SetAsync(user);
        await context.Response.WriteAsync("Hello, Functions Framework.");
    }
}