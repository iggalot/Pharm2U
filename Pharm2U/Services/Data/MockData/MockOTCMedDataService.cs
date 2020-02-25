using Pharm2U.Services.Data.EntityFramework;
using System.Collections.ObjectModel;

namespace Pharm2U.Services.Data.MockData
{
    public class MockOTCMedDataService : IDataService<P2U_OTCMedication>
    {
        #region Constructor
        /// <summary>
        /// Default Constructor for our mock data service
        /// Creates the food items for the database
        /// </summary>
        public MockOTCMedDataService()
        {
            Data = new ObservableCollection<P2U_OTCMedication>()
            {
                //int id, int food_id, int order_id, decimal price, int qty
                new P2U_OTCMedication(1, "Bandaids", "Don't get stuck on me!", (decimal)1.11, true),
                new P2U_OTCMedication(2, "Aspirin", "Basic aspirin", (decimal)2.22, true),
                new P2U_OTCMedication(3, "Cough Medicine", "Cough medicine", (decimal)3.33, true),
                new P2U_OTCMedication(4, "Tongue Depressors", "Say ahhh!", (decimal)4.44, true),
                new P2U_OTCMedication(5, "Bactine", "Disinfectant", (decimal)5.00, true),
          };

        }
        #endregion
    }
}
