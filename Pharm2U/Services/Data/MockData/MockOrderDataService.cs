using Pharm2U.Services.Data.EntityFramework;
using System.Collections.ObjectModel;

namespace Pharm2U.Services.Data.MockData
{

    public class MockOrderDataService : IDataService<P2U_Order>
    {

        #region Constructor
        /// <summary>
        /// Default Constructor for our mock data service
        /// </summary>
        public MockOrderDataService()
        {
            Data = new ObservableCollection<P2U_Order>()
            {
                //(int id, int customer_id, int pharm_id, int deliv_id, string status)
                new P2U_Order(100, 1000, 10000, 1, "New Order"),
                new P2U_Order(200, 2000, 20000, 2, "Ready For Packaging"),
                new P2U_Order(300, 3000, 30000, 3, "Ready for Delivery"),
                new P2U_Order(400, 4000, 40000, 4, "Out for Delivery"),
                new P2U_Order(500, 5000, 50000, 5, "Order Canceled"),
                new P2U_Order(600, 6000, 60000, 6, "Order Complete")                 
                
            };

        }
        #endregion

    }
}
