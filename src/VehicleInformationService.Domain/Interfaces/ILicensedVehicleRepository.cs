using VehicleInformationService.Domain.Models;

namespace VehicleInformationService.Domain.Interfaces;

public interface ILicensedVehicleRepository
{
    Task<IReadOnlyCollection<LicensedVehicle>> GetLicensedVehicles(string? licensePlate, string? brand, string? type);
}
