using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProjectB.Models.DB
{
    public class CustomTotalRentalBySelectedDate
    {
        [Key]
        public string Month { get; set; }
        public string Year { get; set; }
        public decimal TotalRentedSales { get; set; }
    }
}
