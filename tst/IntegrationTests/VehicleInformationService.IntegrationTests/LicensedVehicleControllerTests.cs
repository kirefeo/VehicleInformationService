using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace VehicleInformationService.IntegrationTests;

public class LicensedVehicleControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public LicensedVehicleControllerTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }


    [Fact(DisplayName = "When endpoint is called correctly then endpoint should return statuscode 200")]
    public async Task IT001()
    {
        var client = _factory.CreateClient();
        client.DefaultRequestHeaders.Add("X-API-KEY", "ouU6AQe8V3tPYl6yrM1d");

        var response = await client.GetAsync("LicensedVehicle?licensePlate=0001TJ");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact(DisplayName = "When endpoint is called without query parameters then endpoint should return statuscode 400")]
    public async Task IT002()
    {
        var client = _factory.CreateClient();
        client.DefaultRequestHeaders.Add("X-API-KEY", "ouU6AQe8V3tPYl6yrM1d");

        var response = await client.GetAsync("LicensedVehicle");

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact(DisplayName = "When endpoint is called without api header then endpoint should return statuscode 401")]
    public async Task IT003()
    {
        var client = _factory.CreateClient();
        client.DefaultRequestHeaders.Add("X-API-KEY", "WrongApiKey");

        var response = await client.GetAsync("LicensedVehicle?licensePlate=0001TJ");

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }
}