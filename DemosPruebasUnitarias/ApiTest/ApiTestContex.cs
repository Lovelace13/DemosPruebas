using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Api;
using Microsoft.EntityFrameworkCore;

namespace DemosPruebasUnitarias
{
    public static class ApiTestContex
    {
        public static ApiAppContext GetApiAppContext()
        {
            var options = new DbContextOptionsBuilder<ApiAppContext>().  //Crea base en memoria
                UseInMemoryDatabase(databaseName: "AppDb").Options;

            var dbContext = new ApiAppContext(options);
            //var dbContext_ = AddInitialData(dbContext);
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            return dbContext;
        }

        // Se pone un AddInitialData por tabla Ej: AddInitialDataUser
        public static ApiAppContext AddInitialData(ApiAppContext context)
        {
            context.Users.Add(new User() { 
                Name = "User Test1", 
                LastName = "User Test2" 
            });

            context.SaveChanges();

            return context;
        }
    }
}
