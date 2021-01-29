using System.Collections.Generic;

namespace Got2Insure.Technical.CSharp.VehicleValueService.VehicleValueApi
{
    internal class Lookup
    {
        public string StatusCode { get; set; }

        public string StatusMessage { get; set; }

        public IList<string> AdviceTextList { get; set; }
    }
}
