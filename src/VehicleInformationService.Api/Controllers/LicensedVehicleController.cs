using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using VehicleInformationService.Domain.Interfaces;
using VehicleInformationService.Domain.Models;

namespace VehicleInformationService.Api.Controllers;

[Route("[controller]")]
[ApiController]
public class LicensedVehicleController : ControllerBase
{
    private readonly ILicensedVehicleRepository _licensedVehicleRepository;

    public LicensedVehicleController(ILicensedVehicleRepository licensedVehiclesRepository)
    {
        _licensedVehicleRepository = licensedVehiclesRepository;
    }

    [HttpGet]
    [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(IReadOnlyCollection<LicensedVehicle>))]
    [SwaggerResponse((int)HttpStatusCode.Unauthorized)]
    public async Task<IActionResult> Get(string? licensePlate, string? brand, string? type)
    {
        if (string.IsNullOrWhiteSpace(licensePlate)
            && string.IsNullOrWhiteSpace(brand)
            && string.IsNullOrWhiteSpace(type))
            return BadRequest("Query parameters should not be null or empty.");

        return Ok(await _licensedVehicleRepository.GetLicensedVehicles(licensePlate, brand, type));
    }
}
