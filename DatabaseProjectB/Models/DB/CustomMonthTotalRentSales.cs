using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProjectB.Models.DB
{
    public class CustomMonthTotalRentSales
    {
        [Key]
        public int SelectedMonth { get; set; }
        public int SelectedYear { get; set; }
        public decimal TotalRentedSales { get; set; }
    }
}
