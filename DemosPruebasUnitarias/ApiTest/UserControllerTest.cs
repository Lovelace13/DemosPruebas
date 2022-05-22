using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Api;

namespace DemosPruebasUnitarias.ApiTest
{
    public class UserControllerTest
    {
        [Fact]
        public void UserGet()
        {
            using var apiContext = ApiTestContex.GetApiAppContext();
            var userController = new Api.Controllers.UserController(apiContext);

            var result = userController.Get();

            Assert.Equal(3, result.Count());

        }

        [Fact]
        public void UserGetListActive()
        {
            using var apiContext = ApiTestContex.GetApiAppContext();
            var userController = new Api.Controllers.UserController(apiContext);

            var result = userController.Get().ToList()[0];
            result.Active = false;

            userController.Put(result.UserId.ToString(), result);

            var listResult = userController.Get();

            Assert.True(listResult.ToList()[0].Active);
            Assert.Equal(2, listResult.Count());

        }

        [Fact]
        public void UserPost()
        {
            using var apiContext = ApiTestContex.GetApiAppContext();
            var userController = new Api.Controllers.UserController(apiContext);

            User newUser = new User()
            {
                Name = "User Test",
                LastName = "LastName test"
            };

            userController.Post(newUser).Wait();
            var result = userController.Get();

            Assert.Equal(4, result.Count());
            Assert.Equal("User Test", result.ToList()[3].Name);
        }

        [Fact]
        public void UserPut()
        {
            using var apiContext = ApiTestContex.GetApiAppContext();
            var userController = new Api.Controllers.UserController(apiContext);

            var result = userController.Get().ToList()[0];
            result.Name = "User Updated";

            userController.Put(result.UserId.ToString(), result);
            var listResult = userController.Get().ToList();

            Assert.Equal(3, listResult.Count());
            Assert.Equal("User Updated", listResult.ToList()[0].Name);
        }

        [Fact]
        public void UserDelete()
        {
            using var apiContext = ApiTestContex.GetApiAppContext();
            var userController = new Api.Controllers.UserController(apiContext);

            var firstElement = userController.Get().ToList()[0];
            var result = userController.Delete(firstElement.UserId.ToString());
            var userlist = userController.Get();

            Assert.Equal(2, userlist.Count());
        }
    }
}
