using Pharm2U.Services.Data.EntityFramework;
using Pharm2U.Services.Data.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm2U.Services.Data
{
    public class MockDataService : IDataTables
    { 
        /// <summary>
        /// Constructor that creats the data
        /// </summary>
        public MockDataService()
        {
            // Create the order data
            OrderData = new MockOrderDataService();

            // Create the customer data
            CustomerData = new MockCustomerDataService();

            // Create the food data
            FoodData = new MockFoodDataService();

            // Create the food data for orders
            OrderFoodData = new MockOrderFoodDataService();
        }
    }
}
