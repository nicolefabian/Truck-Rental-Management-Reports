using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseProjectB.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace DatabaseProjectB.Controller
{
    public class DAO
    {
        //View top 5 most rented Trucks
        public static List<CustomTopFiveRentedTrucks> getTopFiveRentedTrucks()
        {
            using (DadNicoleContext ctx = new DadNicoleContext())
            {
                return ctx.TopFiveRentedTrucks.FromSqlRaw("getTopFiveRentedTrucks").ToList();
            }
        }

        //View least 5 rented Truck models
        public static List<CustomLeastRentedModels> getLeastRentedModels()
        {
            using (DadNicoleContext ctx = new DadNicoleContext())
            {
                return ctx.LeastRentedModels.FromSqlRaw("getLeastRentedModels").ToList();
            }
        }

        //Getting all models in TruckModelPb for combobox
        public static List<TruckModelPb> getTruckModels()
        {
            using (DadNicoleContext ctx = new DadNicoleContext())
            {
                return ctx.TruckModelPbs.ToList();
            }
        }

        //View total rental sale for a selected month 
        public static List<CustomMonthTotalRentSales> getMonthTotalRentalSale(int month, int  year)
        {
            using (DadNicoleContext ctx = new DadNicoleContext())
            {
                return ctx.TotalSalesMonth.FromSqlRaw("getMonthTotalRentalSale @p0, @p1", month,year).ToList();
            }
        }

        //View total rental sales of a truck model for the selected date range
        public static List<CustomTotalSalesTruckModel> getTotalSalesTruckModel(string model, DateTime first, DateTime second)
        {
            using (DadNicoleContext ctx = new DadNicoleContext())
            {
                return ctx.TotalSalesTruckModel.FromSqlRaw("getTotalSalesTruckModel @p0, @p1, @p2", model, first, second).ToList();
            }
        }

    }
}
