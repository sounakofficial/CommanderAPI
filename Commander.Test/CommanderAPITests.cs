using Commander.API;
using Commander.API.Controllers;
using FakeItEasy;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Commander.Test
{
    public class CommanderAPITests
    {
        [Fact]
        public void GetWeatherForecast_Returns_Weathers()
        {
            //Arrange
            ILogger<WeatherForecastController> logger = A.Fake<ILogger<WeatherForecastController>>();
            WeatherForecastController weatherForecastController = new WeatherForecastController(logger);
            //Act
            IEnumerable<WeatherForecast> weathers = weatherForecastController.Get();
            //Assert
            Assert.Equal(5, weathers.Count());
        }
    }
}