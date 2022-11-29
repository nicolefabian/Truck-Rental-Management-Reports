using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProjectB.Models.DB
{
    public class CustomTopFiveRentedTrucks
    {
        [Key]
        public int TruckID { get; set; }
        public int TruckModelID { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string RegistrationNumber { get; set; }
        public decimal TotalRentedSales { get; set; }
    }
}
