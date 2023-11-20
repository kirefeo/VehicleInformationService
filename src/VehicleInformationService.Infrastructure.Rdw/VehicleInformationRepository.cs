using VehicleInformationService.Domain.Interfaces;

namespace VehicleInformationService.Infrastructure.Rdw;

public class VehicleInformationRepository : IVehicleInformationRepository
{
    private const string VehicleInformationResource = "resource/m9d7-ebf2.json";

    private readonly HttpClient _httpClient;


    public VehicleInformationRepository(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient(ServiceCollectionExtensions.OpenDataRdwClientName);
    }

    public async Task<object> GetVehicleInformation()
    {
        var response = await _httpClient.GetAsync($"{VehicleInformationResource}?kenteken=0001TJ");
        var information = response.Content.ReadAsStringAsync();

        return information;
    }

}
