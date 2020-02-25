using Pharm2U.Services.Data.MockData;

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

            // Create the food data
            OTCMedData = new MockOTCMedDataService();

            // Create the food data for orders
            OrderOTCMedData = new MockOrderOTCMedsDataService();

            // Create our pharmacy data
            PharmacyData = new MockPharmacyDataService();

            // Create our zip and city data
            ZipCodeData = new MockZipCodeDataService();
        }
    }
}
