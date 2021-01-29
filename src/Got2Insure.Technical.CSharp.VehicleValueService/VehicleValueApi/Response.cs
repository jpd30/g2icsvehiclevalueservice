namespace Got2Insure.Technical.CSharp.VehicleValueService.VehicleValueApi
{
    internal class Response
    {
        public string StatusCode { get; set; }

        public string StatusMessage { get; set; }

        public StatusInformation StatusInformation { get; set; }

        public DataItems DataItems { get; set; }
    }
}
