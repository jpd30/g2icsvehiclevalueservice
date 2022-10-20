using System;

namespace Got2Insure.Technical.CSharp.VehicleValueService
{
    public struct VehicleValueResult : IEquatable<VehicleValueResult>
    {
        public string VehicleRegistration { get; set; }
        public decimal? VehicleValue { get; set; }

        public override bool Equals(object obj) => obj is VehicleValueResult that && this.Equals(that);

        public bool Equals(VehicleValueResult that) => this.VehicleRegistration == that.VehicleRegistration && this.VehicleValue == that.VehicleValue;

        public override int GetHashCode() => HashCode.Combine(this.VehicleRegistration, this.VehicleValue);
        public override string ToString() => $"{{ {this.VehicleRegistration}: {this.VehicleValue} }}";
    }
}
