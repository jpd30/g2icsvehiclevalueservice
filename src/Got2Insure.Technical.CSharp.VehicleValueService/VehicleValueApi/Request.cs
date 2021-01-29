namespace Got2Insure.Technical.CSharp.VehicleValueService.VehicleValueApi
{
    internal class Request
    {
        public string RequestGuid { get; set; }

        public string PackageId { get; set; }

        public int PackageVersion { get; set; }

        public int ResponseVersion { get; set; }

        public DataKeys DataKeys { get; set; }
    }
}
