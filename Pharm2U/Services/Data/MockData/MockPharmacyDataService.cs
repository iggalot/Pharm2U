using Pharm2U.Services.Data.EntityFramework;
using System.Collections.ObjectModel;

namespace Pharm2U.Services.Data.MockData
{
    public class MockPharmacyDataService : IDataService<P2U_Pharmacy>
    {

        #region Constructor
        /// <summary>
        /// Default Constructor for our mock customer data service
        /// </summary>
        public MockPharmacyDataService()
        {
            Data = new ObservableCollection<P2U_Pharmacy>()
            {
                // (int id, string name, string address, string phone, string zip, decimal deliv_price)
                new P2U_Pharmacy(10000, "Pharmacy 1", "111 Anywhere", "555-111-1111", "11111", 1.0m),
                new P2U_Pharmacy(20000, "Pharmacy 2", "222 Anywhere", "555-222-2222", "22222", 2.0m),
                new P2U_Pharmacy(30000, "Pharmacy 3", "333 Anywhere", "555-333-3333", "33333", 3.0m),
                new P2U_Pharmacy(40000, "Pharmacy 4", "444 Anywhere", "555-444-4444", "44444", 4.0m),
                new P2U_Pharmacy(50000, "Pharmacy 5", "555 Anywhere", "555-555-5555", "55555", 5.0m),
                new P2U_Pharmacy(60000, "Pharmacy 6", "666 Anywhere", "555-666-6666", "66666", 6.0m),
                new P2U_Pharmacy(70000, "Pharmacy 7", "777 Anywhere", "555-777-7777", "77777", 7.0m),
                new P2U_Pharmacy(80000, "Pharmacy 8", "888 Anywhere", "555-888-8888", "88888", 8.0m),

            };

        }
        #endregion

    }
}
