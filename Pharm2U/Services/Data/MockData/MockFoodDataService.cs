using Pharm2U.Services.Data.EntityFramework;
using System.Collections.ObjectModel;

namespace Pharm2U.Services.Data.MockData
{
    public class MockFoodDataService : IDataService<P2U_Food>
    {
        #region Constructor
        /// <summary>
        /// Default Constructor for our mock data service
        /// Creates the food items for the database
        /// </summary>
        public MockFoodDataService()
        {
            Data = new ObservableCollection<P2U_Food>()
            {
                //int id, int food_id, int order_id, decimal price, int qty
                new P2U_Food(1, "Chicken Soup", "chicken soup", (decimal)1.11, true, "liquid"),
                new P2U_Food(2, "Grape Jello", "greape jello", (decimal)2.22, true, "unknown"),
                new P2U_Food(3, "Vanilla Ice Cream", "vanilla ice cream", (decimal)3.33, true, "solid"),
                new P2U_Food(4, "Turkey and Dressing", "turkey and dressing", (decimal)4.44, true, "solid"),
                new P2U_Food(5, "Hot Tea", "hot tea", (decimal)5.00, true, "liquid"),
          };

        }
        #endregion
    }
}
