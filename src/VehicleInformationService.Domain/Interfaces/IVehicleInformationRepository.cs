namespace VehicleInformationService.Domain.Interfaces
{
    public interface IVehicleInformationRepository
    {
        Task<object> GetVehicleInformation();
    }
}
