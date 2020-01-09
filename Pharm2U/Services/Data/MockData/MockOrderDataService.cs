using Pharm2U.Models;
using Pharm2U.Models.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Pharm2U.Services.Data.MockData
{

    public class MockOrderDataService : IDataService<OrderModel>
    {

        #region Constructor
        /// <summary>
        /// Default Constructor for our mock data service
        /// </summary>
        public MockOrderDataService()
        {
            Data = new ObservableCollection<OrderModel>()
            {
                new OrderModel
                (
                1000,
                new Customer(1, "John", "Doe", "111 Anywhere Billing", "111 Anywhere Home", "555-1111"),
                new ObservableCollection<Food>()
                    { new Food(10, "Pears", "solid"),
                      new Food(20, "Jello", "jello")
                    },

                new ObservableCollection<OTC>()
                    { new OTC(100, "Tylenol"),
                      new OTC(200, "Bandaids")
                    }
                ),

                new OrderModel
                (
                2000,
                new Customer(2, "Jane", "Smith", "222 Anywhere Billing", "222 Anywhere Home", "555-2222"),
                new ObservableCollection<Food>()
                    { new Food(10, "Oranges", "solid"),
                      new Food(20, "Tea", "liquid")
                    },

                new ObservableCollection<OTC>()
                    { new OTC(100, "Tongue Depressors"),
                      new OTC(200, "Aspirin")
                    }
                ), 
            };

        }
        #endregion

    }
}
