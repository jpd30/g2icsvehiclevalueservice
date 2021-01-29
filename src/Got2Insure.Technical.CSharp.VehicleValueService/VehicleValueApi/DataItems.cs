using System;

namespace Got2Insure.Technical.CSharp.VehicleValueService.VehicleValueApi
{
    internal class DataItems
    {
        public string Vrm { get; set; }

        public string Mileage { get; set; }

        public string PlateYear { get; set; }

        public ValuationList ValuationList { get; set; }

        public DateTime ValuationTime { get; set; }

        public string VehicleDescription { get; set; }

        public string ValuationBook { get; set; }

        public int ExtractNumber { get; set; }
    }
}
