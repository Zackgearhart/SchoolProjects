using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5Gearhart.Models
{
    public class FuelContext : DbContext
    {
        public FuelContext(DbContextOptions<FuelContext> options) : base(options) { }
        public DbSet<FuelRecordModel> FuelRecordModels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FuelRecordModel>().HasData(
                new FuelRecordModel
                {
                    FuelRecordModelId = 1,
                    mileage = 0,
                    numberGallons = 0,
                    pricePaid = 0,
   
                }
                );
        }
    }

}
