namespace BookHub.Core;

public class Function : IHttpFunction
{
    public async Task HandleAsync(HttpContext context)
    {
        await context.Response.WriteAsync("Hello World!");
    }
}