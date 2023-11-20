using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VehicleInformationService.Domain.Interfaces;

namespace VehicleInformationService.Infrastructure.Rdw;

public static class ServiceCollectionExtensions
{
    internal const string OpenDataRdwClientName = "OpenDataRdw";

    public static void AddRdwApi(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient(OpenDataRdwClientName, client =>
        {
            client.BaseAddress = new Uri(configuration["RdwApi:BaseUrl"]);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("X-App-Token", configuration["RdwApi:AppToken"]);
        });

        services.AddTransient<IVehicleInformationRepository, VehicleInformationRepository>();
    }
}