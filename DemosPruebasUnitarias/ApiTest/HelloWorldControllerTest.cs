using System;
using System.Collections.Generic;
using Xunit;
using Api.Controllers;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace DemosPruebasUnitarias
{
    public class HelloWorldControllerTest
    {
        [Fact]
        public void GetTModels()
        {
            var controlador = new HelloWorldController();
            var result = controlador.GetTModels();

            Assert.NotNull(result);
            Assert.Equal(2, result.Value.Count());
        }

        [Fact]
        public void GetById()
        {
            var controlador = new HelloWorldController();
            var result = controlador.GetById(2);
            Assert.NotNull(result);
            Assert.Equal("Hello World", result.Value);
        }

        [Fact]
        public void GetById_BadRequest()
        {
            var controlador = new HelloWorldController();
            var result = controlador.GetById(-2);
            Assert.IsType<BadRequestResult>(result.Result);
        }

        [Fact]
        public void GetById_NotFound()
        {
            var controlador = new HelloWorldController();
            var result = controlador.GetById(0);
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public void Post()
        {
            var controlador = new HelloWorldController();
            var result = controlador.PostTModel("");
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public void Put()
        {
            var controlador = new HelloWorldController();
            var result = controlador.PutTModel("");
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public void Delete()
        {
            var controlador = new HelloWorldController();
            var result = controlador.DeleteTModelById("");
            Assert.Null(result);
        }

    }
}
