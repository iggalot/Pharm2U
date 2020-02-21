using Pharm2U.Services.Data.EntityFramework;
using System.Collections.ObjectModel;

namespace Pharm2U.Services.Data.MockData
{
    public class MockZipCodeDataService : IDataService<P2U_ZipCodes>
    {

        #region Constructor
        /// <summary>
        /// Default Constructor for our mock customer data service
        /// </summary>
        public MockZipCodeDataService()
        {
            Data = new ObservableCollection<P2U_ZipCodes>()
            {
                //(int id, string zip, string city, string county, string state, string country, double latitude, double longitude)
                new P2U_ZipCodes(11111, "11111", "City 1", "County 1", "State 1", "Country 1", 100.0, 100.1),
                new P2U_ZipCodes(22222, "22222", "City 2", "County 2", "State 2", "Country 2", 200.0, 200.1),
                new P2U_ZipCodes(33333, "33333", "City 3", "County 3", "State 3", "Country 3", 300.0, 300.1),
                new P2U_ZipCodes(44444, "44444", "City 4", "County 4", "State 4", "Country 4", 400.0, 400.1),
                new P2U_ZipCodes(55555, "55555", "City 5", "County 5", "State 5", "Country 5", 500.0, 500.1),
                new P2U_ZipCodes(66666, "66666", "City 6", "County 6", "State 6", "Country 6", 600.0, 600.1),
                new P2U_ZipCodes(77777, "77777", "City 7", "County 7", "State 7", "Country 7", 700.0, 700.1),
                new P2U_ZipCodes(88888, "88888", "City 8", "County 8", "State 8", "Country 8", 800.0, 800.1),

            };

        }
        #endregion

    }
}
