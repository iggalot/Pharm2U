using Pharm2U.Services.Data;
using Pharm2U.Services.Data.EntityFramework;
using Pharm2U.ViewModels;

namespace Pharm2U.Models.Data
{
    public class AddressData
    {
        public string Zip { get; set; }
        public string City { get; set; } = null;
        public string County { get; set; } = null;
        public string State { get; set; } = null;
        public string Country { get; set; } = null;
        public string Street { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="street">Street address</param>
        /// <param name="zip">Specified zip code</param>
        public AddressData(string street, string zip)
        {
            this.Street = street;
            this.Zip = zip;

            // Get the datatables
            IDataTables dt = IoC.IoCContainer.Get<ApplicationViewModel>().DataTables;

            foreach (P2U_ZipCodes item in dt.ZipCodeData.Data)
            {
                if(item.Zip == zip)
                {
                    City = item.City;
                    County = item.County;
                    State = item.State;
                    Country = item.Country;
                }
            }
        }
    }
}
