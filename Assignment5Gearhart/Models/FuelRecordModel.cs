using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5Gearhart.Models
{
    public class FuelRecordModel
    {
        public int FuelRecordModelId {get; set;}
        [DisplayName("Fill Up Mileage: ")]
        [Required(ErrorMessage = "Must enter valid number of Miles")]
        [Range(1, 1000, ErrorMessage = "Mileage must be more than 0 and No more than 1000")]
        [Column(TypeName ="decimal(18,4)")]
        public decimal mileage { get; set; }
        [DisplayName("Date Purchased: ")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime datePurchased { get; set; }
        [Required(ErrorMessage = "Must enter valid number of Gallons")]
        [Range(1, 50, ErrorMessage = "Gallons must be more than 0 and No more than 1000")]
        [Column(TypeName = "decimal(18,4)")]
        [DisplayName("Fill Up Gallons: ")]
        public decimal numberGallons { get; set; }
        [Required(ErrorMessage = "Must enter valid Price")]
        [Range(1, 1000, ErrorMessage = "Price must be more than 0 and No more than 1000")]
        [Column(TypeName = "decimal(18,4)")]
        [DisplayName("Total Price Paid: ")]
        public decimal pricePaid { get; set; }

        public decimal MilesPerGallon(decimal milesDriven)
        {
            if (numberGallons != 0)
            {
                return milesDriven / numberGallons;
            }
            else
            {
                return 0;
            }
        }
        public decimal CostPerMile(decimal milesDriven)
        {
            if (pricePaid != 0)
            {
                return milesDriven / pricePaid;
            }else
            {
                return 0;
            }
        }
        public decimal milesDriven(decimal perviousMilage)
        {

                return mileage - perviousMilage;
            

        }

    }
}
