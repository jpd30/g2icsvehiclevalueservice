using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Linq;
using System.Net.Http;

namespace Got2Insure.Technical.CSharp.VehicleValueService.Tests
{
    public class Tests
    {
        private const string Got2InsureSettingsFilePath = @"%TEMP%\got2insure.settings.json";

        private ServiceProvider serviceProvider;

        [SetUp]
        public void Setup()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(Environment.ExpandEnvironmentVariables(Got2InsureSettingsFilePath))
                .Build();
            this.serviceProvider = new ServiceCollection()
                .AddTransient<IVehicleValueService, VehicleValueService>()
                .AddSingleton(new HttpClient())
                .AddSingleton(config)
                .BuildServiceProvider();
        }

        [Test]
        public void VehicleValueServiceShouldReturnValueForSingleVehicleRegistration()
        {
            var vehicleValueService = serviceProvider.GetService<IVehicleValueService>();
            var result = vehicleValueService.GetVehicleValues(new[] { "VA16OFZ" }).ToList();
            CollectionAssert.AreEqual(new[] { new VehicleValueResult { VehicleRegistration = "VA16OFZ", VehicleValue = 15600m } }, result);
        }

        [Test]
        public void VehicleValueServiceShouldReturnValueForMultipleVehicleRegistrations()
        {
            var vehicleRegistrations = new[]
            {
                "VA16OFZ",
                "AY11UBS",
                "AHJ128E"
            };

            var vehicleValueService = serviceProvider.GetService<IVehicleValueService>();
            var result = vehicleValueService.GetVehicleValues(vehicleRegistrations).ToList();
            Assert.AreEqual(3, result.Count);
        }
    }
}