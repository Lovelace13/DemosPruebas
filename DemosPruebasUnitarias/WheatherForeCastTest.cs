using System;
using System.Collections.Generic;
using Xunit;
using Api;
using Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace DemosPruebasUnitarias
{
    public class WheatherForeCastTest
    {
        [Fact]
        public void GetWheatherForeCast()
        {
            
            var controlador = new WeatherForecastController();
            var result = controlador.Get();

            Assert.NotNull(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public void GetWheatherForeCast_ItemValues()
        {

            var controlador = new WeatherForecastController();
            var result = controlador.Get().ToList()[0];

            Assert.NotNull(result);
            Assert.NotEmpty(result.Summary);
            Assert.True(result.TemperatureC > -20);
            Assert.True(result.Date > new DateTime());
        }
    }
}
