using System.Collections.Generic;

namespace Got2Insure.Technical.CSharp.VehicleValueService
{
    public interface IVehicleValueService
    {
        IEnumerable<VehicleValueResult> GetVehicleValues(IEnumerable<string> vehicleRegistrations);
    }
}
