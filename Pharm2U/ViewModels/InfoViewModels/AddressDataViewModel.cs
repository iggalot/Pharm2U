using Pharm2U.Services.Data;
using Pharm2U.Services.Data.EntityFramework;
using Pharm2U.ViewModels;
using System;
using System.Windows;

namespace Pharm2U.ViewModels.InfoiViewModels
{
    /// <summary>
    /// A class for storing the filtered data from an address and zip code.
    /// Allows the City, State information to be conveniently displayed and retrieved.
    /// </summary>
    public class AddressDataViewModel
    {
        public string Zip { get; set; }
        public string City { get; set; } = null;
        public string County { get; set; } = null;
        public string State { get; set; } = null;
        public string Country { get; set; } = null;
        public string Street { get; set; }

        public string CityStateString
        {
            get
            {
                // If a parameter is null, return it as "N/A" in the display
                string unknownstr = "N/A";
                string str = string.Empty;
                str += ((City == null) || (City == String.Empty) ? unknownstr : City) + ", ";
                str += ((State == null) || (State == String.Empty) ? unknownstr : State) + ", ";
                str += ((Country == null) || (Country == String.Empty) ? unknownstr : Country) + ", ";
                str += Zip;

                return str;

            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="street">Street address</param>
        /// <param name="zip">Specified zip code</param>
        public AddressDataViewModel(string street, string zip)
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
