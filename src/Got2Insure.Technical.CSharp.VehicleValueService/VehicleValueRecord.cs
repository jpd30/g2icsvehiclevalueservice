using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Got2Insure.Technical.CSharp.VehicleValueService
{
    [Table("VehicleValue")]
    public class VehicleValueRecord
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int Id { get; set; }
        public string VehicleRegistration { get; set; }
        public decimal VehicleValue { get; set; }
        public DateTime Created { get; set; }
    }
}
