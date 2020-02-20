using Pharm2U.Services.Data.EntityFramework;
using System.Collections.ObjectModel;

namespace Pharm2U.Services.Data.MockData
{
    public class MockOrderOTCMedsDataService : IDataService<P2U_OrderOTCMeds>
    {

        #region Constructor
        /// <summary>
        /// Default Constructor for our mock data service
        /// Creates the food date items for specific orders
        /// </summary>
        public MockOrderOTCMedsDataService()
        {
            Data = new ObservableCollection<P2U_OrderOTCMeds>()
            {
                //int id, int food_id, int order_id, decimal price, int qty
                new P2U_OrderOTCMeds(1, 1, 100, (decimal)1.11, 1),
                new P2U_OrderOTCMeds(2, 2, 100, (decimal)2.22, 2),
                new P2U_OrderOTCMeds(3, 3, 100, (decimal)3.33, 3),
                new P2U_OrderOTCMeds(4, 1, 200, (decimal)1.11, 1),
                new P2U_OrderOTCMeds(5, 2, 200, (decimal)2.22, 2),
                new P2U_OrderOTCMeds(6, 4, 200, (decimal)4.44, 4),
                new P2U_OrderOTCMeds(7, 5, 200, (decimal)5.55, 5),
                new P2U_OrderOTCMeds(8, 1, 300, (decimal)1.11, 1),
                new P2U_OrderOTCMeds(9, 2, 400, (decimal)2.22, 2),
                new P2U_OrderOTCMeds(10, 3, 500, (decimal)3.33, 3),
                new P2U_OrderOTCMeds(11, 4, 500, (decimal)4.00, 4),
          };

        }
        #endregion
    }
}
