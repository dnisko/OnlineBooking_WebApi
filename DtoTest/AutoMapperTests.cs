using AutoMapper;
using Mappers;

namespace DtoTest
{
    public class AutoMapperTests
    {
        [Fact]
        public void AutoMapper_Configuration_IsValid()
        {
            // Arrange
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());

            // Act & Assert
            configuration.AssertConfigurationIsValid();
        }
    }
}