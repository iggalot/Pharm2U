using Pharm2U.Services.Data.EntityFramework;
using System;

namespace Pharm2U.Services.Data
{
    /// <summary>
    /// An interface for defining the data tables that the application will need
    /// </summary>
    public abstract class IDataTables
    {
        // The order data
        public IDataService<P2U_Order> OrderData { get; set; }

        // The customer data
        public IDataService<P2U_Customer> CustomerData { get; set; }

        // The food data for each order
        public IDataService<P2U_OrderFood> OrderFoodData { get; set; }

        // The food data for each order
        public IDataService<P2U_Food> FoodData { get; set; }


        public override string ToString()
        {
            var str = this.Display();
            return str ;
        }

        /// <summary>
        /// Display the contents of our DataTable object
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            var str = String.Empty;
            str += "---- Order Data ----\n";
            str += OrderData.Display();
            str += "---- Customer Data ----\n";
            str += CustomerData.Display();
            str += "---- Food Data ----\n";
            str += FoodData.Display();
            str += "---- OrderFood Data ----\n";
            str += OrderFoodData.Display();
            return str;
        }
    }
}
