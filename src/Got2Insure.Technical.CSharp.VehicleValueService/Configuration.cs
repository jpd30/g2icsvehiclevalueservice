namespace Got2Insure.Technical.CSharp.VehicleValueService
{
    internal static class Configuration
    {
        public const string VehicleDataApiUri = "https://uk1.ukvehicledata.co.uk/api/datapackage/ValuationData?v=2&api_nullitems=1&auth_apikey={apiKey}&user_tag=&key_VRM={vehicleRegistration}&key_mileage=";
        public const string VehicleDataApiKey = "";
        public const string CacheBlobStoreUri = "https://g2iscratchjpd.blob.core.windows.net/csharpvehicledata?sv=2019-12-12&st=2021-01-28T09%3A00%3A00Z&se=2021-01-29T18%3A00%3A00Z&sr=c&sp=racwl&sig=PQ3ZDn9yCAqPYsy6aw3yTz1SzQjzgSXlRu9tAm8iFlk%3D";
    }
}
