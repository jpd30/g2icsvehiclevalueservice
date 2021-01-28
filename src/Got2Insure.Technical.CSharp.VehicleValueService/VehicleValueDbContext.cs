using Microsoft.EntityFrameworkCore;
using System;

namespace Got2Insure.Technical.CSharp.VehicleValueService
{
    public class VehicleValueDbContext : DbContext
    {
        public DbSet<VehicleValueRecord> VehicleValues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Environment.ExpandEnvironmentVariables(@"%TEMP%\got2insure.vehiclevalueservice.cache.sqlite"));
        }
    }
}
