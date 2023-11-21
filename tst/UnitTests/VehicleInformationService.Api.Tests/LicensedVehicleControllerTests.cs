using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using VehicleInformationService.Api.Controllers;
using VehicleInformationService.Domain.Interfaces;

namespace VehicleInformationService.Api.Tests
{
    public class LicensedVehicleControllerTests
    {
        private readonly Mock<ILicensedVehicleRepository> _licensedVehicleRepositoryMock;
        private readonly LicensedVehicleController _controller;

        public LicensedVehicleControllerTests()
        {
            _licensedVehicleRepositoryMock = new Mock<ILicensedVehicleRepository>();
            _controller = new LicensedVehicleController(_licensedVehicleRepositoryMock.Object);
        }

        [Fact(DisplayName = "LVC-001: When call is correct then repository should be called and HttpStatus code should be 200.")]
        public async Task LVC001()
        {
            string? licencePlate = "TEST";
            string? brand = "TEST";
            string? type = "TEST";

            var result = await _controller.Get(licencePlate, brand, type);

            result.Should().BeAssignableTo<OkObjectResult>();
            _licensedVehicleRepositoryMock.Verify(
                m => m.GetLicensedVehicles(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), 
                Times.Once());
        }

        [Fact(DisplayName = "LVC-002: When all query parameters are empty then repository should not be called and HttpStatus code should be 400.")]
        public async Task LVC002()
        {
            string? licencePlate = null!;
            string? brand = null!;
            string? type = null!;

            var result = await _controller.Get(licencePlate, brand, type);

            result.Should().BeAssignableTo<BadRequestObjectResult>();
            _licensedVehicleRepositoryMock.Verify(
                m => m.GetLicensedVehicles(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()),
                Times.Never);
        }
    }
}