using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;

namespace Got2Insure.Technical.CSharp.VehicleValueService
{
    public class VehicleValueService : IVehicleValueService
    {
        private readonly IConfiguration configuration;
        private readonly HttpClient httpClient;
        private readonly VehicleValueDbContext vehicleValueDbContext;

        public VehicleValueService(IConfiguration configuration, HttpClient httpClient)
        {
            this.configuration = configuration;
            this.httpClient = httpClient;
            this.vehicleValueDbContext = new VehicleValueDbContext();
            this.vehicleValueDbContext.Database.EnsureCreated();
        }

        public IEnumerable<VehicleValueResult> GetVehicleValues(IEnumerable<string> vehicleRegistrations)
        {
            var vehicleValueApiUri = this.configuration["vehicleValueApiUri"];
            var vehicleValueApiKey = this.configuration["vehicleValueApiKey"];
            var vehicleValueJsonPath = "Response.DataItems.ValuationList.PrivateAverage";

            var vehicleValueCacheSasUri = this.configuration["vehicleValueCacheSasUri"];

            /* TASK 0: Build the solution and run the two included tests.
             * 
             * The `VehicleValueServiceShouldReturnValueForSingleVehicleRegistration` test should PASS.
             * The `VehicleValueServiceShouldReturnValueForMultipleVehicleRegistrations` test should FAIL.
             *
             * Comment out the following line before starting TASK 1.
             */
            yield return new VehicleValueResult { VehicleRegistration = "VA16OFZ", VehicleValue = 15600m };

            /* TASK 1: Write code to call the "Vehicle Value API" to obtain the monetary values of vehicles for the supplied list of vehicle registrations.
             * 
             * The `vehicleValueApiUri` string has two placeholders:
             *   "{apiKey}" needs to be replaced with the supplied `vehicleValueApiKey`
             *   "{vehicleRegistration}" needs to be replaced with a vehicle registration.
             *   
             * Using the provided `httpClient`, make a HTTP GET call to the Vehicle Value API for each vehicle using the modified `vehicleValueApiUri`.
             * 
             * The response from the Vehicle Value API is in the form of a JSON object.
             * EITHER interpret the response as raw JSON OR deserialize it as an instance of `VehicleDataV2` (see the object model in the `VehicleValueApi` folder).
             * Extract the value using the JsonPath given by `vehicleValueJsonPath` (or the equivalent if using the object model).
             * 
             * Return the result as a sequence of `VehicleValueResult`. N.B. you will need to return one `VehicleValueResult` for each vehicle registration.
             */

            /* TASK 2: Store the Vehicle Value API responses to an Azure Storage Blob Container.
             * 
             * Store the full response for each vehicle registration into the blob container which can be accessed using vehicleValueCacheSasUri.
             * 
             * Blobs should be named "{vehicleRegistration}-{currentDate:yyyyMMddTHHmmssZ}".
             */

            /* TASK 3: The call to the VehicleValueApi is expensive. Implement a basic cache to avoid repeated reqeusts.
             * 
             * If the cache contains an entry for a given vehicle registration then you should return the cached value without calling the Vehicle Value API;
             * otherwise, call the Vehicle Value API (as per TASK 1) and store the result to the cache before returning the result.
             * 
             * Choose EITHER TASK 3a OR TASK 3b.
             * 
             * TASK 3a: Use the Blob Container populated in TASK 2 as the cache.
             * 
             * TASK 3b: Use the Entity Framework Core Database Context `vehicleValueDbContext` to read from and write to a database cache.
             */

            /* TASK 4: You get feedback from the users of the VehicleValueService that the call to GetVehicleValue() is taking
             * too long for large numbers of VRNs.
             * 
             * Use parallelisation to speed up the call by making up to 4 simultaneous requests to the Vehicle Value API.
             */
        }
    }
}
