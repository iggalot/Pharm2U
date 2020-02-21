using Pharm2U.Services.Data.EntityFramework;
using System;

namespace Pharm2U.Services.Data
{
    /// <summary>
    /// An interface for defining the data tables that the application will need
    /// </summary>
    public abstract class IDataTables
    {
        #region Public Properties
        // The order data
        public IDataService<P2U_Order> OrderData { get; set; }

        // The customer data
        public IDataService<P2U_Customer> CustomerData { get; set; }

        // The food data for each order
        public IDataService<P2U_OrderFood> OrderFoodData { get; set; }

        // The food data for each order
        public IDataService<P2U_OrderOTCMeds> OrderOTCMedData { get; set; }


        // The food data from the database
        public IDataService<P2U_Food> FoodData { get; set; }

        // The OTC medication data from the database
        public IDataService<P2U_OTCMedication> OTCMedData { get; set; }

        // The pharmacy information from the database
        public IDataService<P2U_Pharmacy> PharmacyData { get; set; }

        // The delivery company information for each order
        public IDataService<P2U_DeliveryCompany> DeliveryCompanyData { get; set; }

        // The delivery area information
        public IDataService<P2U_DeliveryCompany> DeliveryAreaData { get; set; }

        // The zipcode information containing city and state information
        public IDataService<P2U_ZipCodes> ZipCodeData { get; set; }
        #endregion

        #region Public Methods
        public override string ToString()
        {
            var str = this.Display();
            return str;
        }

        /// <summary>
        /// Display the contents of our DataTable object
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            var str = String.Empty;
            str += "---- Order Data ----\n";
            str += OrderData.Display();
            str += "---- Customer Data ----\n";
            str += CustomerData.Display();
            str += "---- Food Data ----\n";
            str += FoodData.Display();
            str += "---- OrderFood Data ----\n";
            str += OrderFoodData.Display();
            str += "---- OTCMeds Data ----\n";
            str += OTCMedData.Display();
            str += "---- OrderOTCMed Data ----\n";
            str += OrderOTCMedData.Display();
            str += "---- Pharmacy Data ----\n";
            str += PharmacyData.Display();
            str += "---- Zip code Data ----\n";
            str += ZipCodeData.Display();
            return str;
        } 
        #endregion
    }
}
