﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WebApi.Data.EF
{
    class WebApiContextFactory : IDesignTimeDbContextFactory<WebApiDbContext>
    {
        public WebApiDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var connectionString = configuration.GetConnectionString("BookingFieldDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<WebApiDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new WebApiDbContext(optionsBuilder.Options);
        }
    }
}
