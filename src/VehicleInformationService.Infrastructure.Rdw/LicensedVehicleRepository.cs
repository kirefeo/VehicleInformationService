using System.Net.Http.Json;
using VehicleInformationService.Domain.Interfaces;
using VehicleInformationService.Domain.Models;

namespace VehicleInformationService.Infrastructure.Rdw;

public class LicensedVehicleRepository : ILicensedVehicleRepository
{
    private const string LicensedVehicleResource = "resource/m9d7-ebf2.json";
    private const int ResultLimit = 50;
    private readonly HttpClient _httpClient;


    public LicensedVehicleRepository(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient(ServiceCollectionExtensions.OpenDataRdwClientName);
    }

    public async Task<IReadOnlyCollection<LicensedVehicle>> GetLicensedVehicles(string? licensePlate, string? brand, string? type)
    {
        var queryParameters = new List<string>();

        if (!string.IsNullOrWhiteSpace(licensePlate))
            queryParameters.Add($"kenteken like '%25{licensePlate.ToUpper()}%25'");
        if (!string.IsNullOrWhiteSpace(brand))
            queryParameters.Add($"merk like '%25{brand.ToUpper()}%25'");
        if (!string.IsNullOrWhiteSpace(type))
            queryParameters.Add($"handelsbenaming like '%25{type.ToUpper()}%25'");

        var queryParameterString = $"$where={string.Join(" AND ", queryParameters)}";

        var response = await _httpClient.GetAsync($"{LicensedVehicleResource}?{queryParameterString}&$limit={ResultLimit}");
        var information = await response.Content.ReadFromJsonAsync<LicensedVehicleDto[]>();

        return information.ToModel();
    }
}
