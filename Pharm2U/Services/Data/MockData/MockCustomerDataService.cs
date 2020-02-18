using Pharm2U.Services.Data.EntityFramework;
using System.Collections.ObjectModel;

namespace Pharm2U.Services.Data.MockData
{
    public class MockCustomerDataService : IDataService<P2U_Customer>
    {

        #region Constructor
        /// <summary>
        /// Default Constructor for our mock customer data service
        /// </summary>
        public MockCustomerDataService()
        {
            Data = new ObservableCollection<P2U_Customer>()
            {
                new P2U_Customer(1000, "John", "Doe", "111 Anywhere", "City 1", "State 1", "11111", "555-111-1111", "111@email.com"),
                new P2U_Customer(2000, "Jane", "Doe", "222 Anywhere", "City 2", "State 2", "22222", "555-222-2222", "222@email.com"),
                new P2U_Customer(3000, "John", "Smith", "333 Anywhere", "City 3", "State 3", "33333", "555-333-3333", "333@email.com"),
                new P2U_Customer(4000, "Jane", "Smith", "444 Anywhere", "City 4", "State 4", "44444", "555-444-4444", "444@email.com"),
                new P2U_Customer(5000, "Bob", "Bobertson", "555 Anywhere", "City 5", "State 5", "55555", "555-555-5555", "555@email.com"),
                new P2U_Customer(6000, "Rob", "Robertson", "666 Anywhere", "City 6", "State 6", "66666", "555-666-6666", "666@email.com"),
                new P2U_Customer(7000, "John", "Doe", "777 Anywhere", "City 7", "State 7", "77777", "555-777-7777", "777@email.com")
            };

        }
        #endregion

    }
}
