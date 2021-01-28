using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;

namespace Got2Insure.Technical.CSharp.VehicleValueService
{
    public class VehicleValueService : IVehicleValueService
    {
        private readonly IConfiguration configuration;
        private readonly HttpClient httpClient;

        public VehicleValueService(IConfiguration configuration, HttpClient httpClient)
        {
            this.configuration = configuration;
            this.httpClient = httpClient;
        }

        public IEnumerable<VehicleValueResult> GetVehicleValue(IEnumerable<string> vehicleRegistrations)
        {
            var vehicleValueApiUri = this.configuration["vehicleValueApiUri"];
            var vehicleValueApiKey = this.configuration["vehicleValueApiKey"];
            var vehicleValueJsonPath = "Response.DataItems.ValuationList.PrivateAverage";

            var vehicleValueCacheSasUri = this.configuration["vehicleValueCacheSasUri"];

            // Example return value - comment out before starting TASK 1.
            yield return new VehicleValueResult { VehicleRegistration = "VA16OFZ", VehicleValue = 15600m };

            /* TASK 1: Implement service to get the value of vehicles with the supplied list of vehicle registrations.
             * Replace "{apiKey}" and "{vehicleRegistration}" with the appropriate values in the vehicleValueApiUri string.
             * Make a HTTP GET call to the VehicleValueApi for each vehicle, using the provided API URI and key.
             * Interpret the API response as JSON and extract the vehicle value using the provided JSONPath.
             * Return the result as a sequence of VehicleValueResult.
             */

            /* TASK 2: Store the VehicleValueApi responses to an Azure Storage Blob Container.
             * Store the full response for each vehicle registration using the provided Shared-Access Signature URI.
             * Blobs should be named "{vehicleRegistration}-{currentData:yyyyMMddTHHmmssZ}".
             */

            /* TASK 3: The call to the VehicleValueApi is expensive. Implement a basic cache to avoid repeated reqeusts.
             * You will need to call the service and store the result to the cache if the vehicle does not have an entry already in the cache.
             * Choose TASK 3a _OR_ TASK 3b.
             * 
             * TASK 3a: Use the Blob Container as a cache to avoid repeated requests by vehicle registration.
             * 
             * TASK 3b: Use Entity Framework Core to create a local SQLite cache.
             * You may use the provided VehicleValueDbContext for this purpose. Use the following statement to ensure the local cache file exists:
             * context.Database.EnsureCreated();
             */

            /* TASK 4: You get feedback that the call to GetVehicleValue() is taking too long for large numbers of VRNs.
             * Use parallelisation to speed up the call by making upto 4 simultaneous requests to the VehicleValueApi.
             */
        }
    }
}
