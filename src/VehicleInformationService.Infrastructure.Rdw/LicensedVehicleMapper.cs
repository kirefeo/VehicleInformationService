using VehicleInformationService.Domain.Models;

namespace VehicleInformationService.Infrastructure.Rdw;

internal static class LicensedVehicleMapper
{
    internal static IReadOnlyCollection<LicensedVehicle> ToModel(this LicensedVehicleDto[]? dtos)
    {
        if (dtos == null)
        {
            return new List<LicensedVehicle>();
        }

        return dtos
            .Select(dto => new LicensedVehicle(dto.Kenteken, dto.Merk, dto.Handelsbenaming, dto.DatumTenaamstellingDt.GetValueOrDefault().Year))
            .ToList();
    }
}
