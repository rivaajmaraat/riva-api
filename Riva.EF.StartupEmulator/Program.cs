using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using Riva.Models.HAYDEN;

namespace Riva.EF.StartupEmulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class HAYDENContextFactory : IDesignTimeDbContextFactory<HAYDENContext>
        {
            private const string migrationOptionsFile = "MigrationOptions.json";
            public HAYDENContext CreateDbContext(string[] args)
            {
                while (!File.Exists(migrationOptionsFile))
                {
                    Console.WriteLine("MigrationOptions.json is missing.");
                }

                IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
                    .SetBasePath(Environment.CurrentDirectory)
                    .AddJsonFile(migrationOptionsFile);

                IConfigurationRoot configRoot = configurationBuilder.Build();

                args = new string[] { configRoot.GetConnectionString("HAYDEN") };
                string connectionString = args[0];
                var optionsBuilder = new DbContextOptionsBuilder<HAYDENContext>();
                Console.WriteLine($"Using connection string: {connectionString}");
                optionsBuilder.UseSqlServer(connectionString);
                return new HAYDENContext(optionsBuilder.Options);
            }
        }
    }
}
