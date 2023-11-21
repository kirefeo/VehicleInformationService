using System.Net;

namespace VehicleInformationService.Api.Middleware;

public class ApiKeyMiddleware
{
    private readonly RequestDelegate _requestDelegate;
    internal const string ApiKey = "X-API-KEY";

    public ApiKeyMiddleware(RequestDelegate requestDelegate)
    {
        _requestDelegate = requestDelegate;
    }

    public async Task Invoke(HttpContext context)
    {
        if (!context.Request.Headers.TryGetValue(ApiKey, out var apiKeyValue))
        {
            context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            await context.Response.WriteAsync("Missing X-API-KEY Header");
            return;
        }

        var appSettings = context.RequestServices.GetRequiredService<IConfiguration>();
        var apiKey = appSettings.GetValue<string>(ApiKey);
        if (!apiKeyValue.Equals(apiKey))
        {
            context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            await context.Response.WriteAsync("Unauthorized client");
            return;
        }

        await _requestDelegate(context);
    }
}
