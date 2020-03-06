using Pharm2U.Services.Data.EntityFramework;
using Pharm2U.Utilities;
using System;

namespace Pharm2U.Services.Data
{
    /// <summary>
    /// An interface for defining the data tables that the application will need
    /// </summary>
    public abstract class IDataTables : ObservableObject
    {
        #region Private Members
        private static IDataService<P2U_Order> _mOrderData;
        private static IDataService<P2U_Customer> _mCustomerData;
        private static IDataService<P2U_OrderFood> _mOrderFoodData;
        private static IDataService<P2U_OrderOTCMeds> _mOrderOTCMedData;
        private static IDataService<P2U_Food> _mFoodData;
        private static IDataService<P2U_OTCMedication> _mOTCMedData;
        private static IDataService<P2U_Pharmacy> _mPharmacyData;

        #endregion
        #region Public Properties
        // The order data
        public IDataService<P2U_Order> OrderData
        {
            get => _mOrderData;
            set
            {
                _mOrderData = value;

                OnPropertyChanged("OrderData");

            }
        }

        // The customer data
        public IDataService<P2U_Customer> CustomerData
        {
            get => _mCustomerData;
            set
            {
                _mCustomerData = value;

                OnPropertyChanged("CustomerData");

            }
        }

        // The food data for each order
        public IDataService<P2U_OrderFood> OrderFoodData
        {
            get => _mOrderFoodData;
            set
            {
                _mOrderFoodData = value;

                OnPropertyChanged("OrderFoodData");

            }
        }

        // The food data for each order
        public IDataService<P2U_OrderOTCMeds> OrderOTCMedData
        {
            get => _mOrderOTCMedData;
            set
            {
                _mOrderOTCMedData = value;

                OnPropertyChanged("OrderOTCMedData");
            }
        }


        // The food data from the database
        public IDataService<P2U_Food> FoodData
        {
            get => _mFoodData;
            set
            {
                _mFoodData = value;
                OnPropertyChanged("FoodData");
            }
        }

        // The OTC medication data from the database
        public IDataService<P2U_OTCMedication> OTCMedData
        {
            get => _mOTCMedData;
            set
            {
                _mOTCMedData = value;

                OnPropertyChanged("OTCMedData");

            }
        }

        // The pharmacy information from the database
        public IDataService<P2U_Pharmacy> PharmacyData 
        { 
            get => _mPharmacyData;
            set {
                _mPharmacyData = value;

                OnPropertyChanged("PharmacyData");

            }
        }

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
