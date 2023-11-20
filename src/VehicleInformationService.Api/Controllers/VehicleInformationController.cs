using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using VehicleInformationService.Domain.Interfaces;

namespace VehicleInformationService.Api.Controllers;

[Route("[controller]")]
[ApiController]
public class VehicleInformationController : ControllerBase
{
    private readonly IVehicleInformationRepository _vehicleInformationRepository;

    public VehicleInformationController(IVehicleInformationRepository vehicleInformationRepository)
    {
        _vehicleInformationRepository = vehicleInformationRepository;
    }

    [HttpGet("vehicleinformation")]
    [SwaggerResponse((int)HttpStatusCode.OK)]
    [SwaggerResponse((int)HttpStatusCode.Unauthorized)]
    public async Task<IActionResult> Get()
    {
        var results = await _vehicleInformationRepository.GetVehicleInformation();
        return Ok(results);
    }
}
