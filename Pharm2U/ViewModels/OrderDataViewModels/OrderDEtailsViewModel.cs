using Pharm2U.Models.Data;
using Pharm2U.Services.Data;
using Pharm2U.Services.Data.EntityFramework;
using Pharm2U.Utilities;
using Pharm2U.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;

namespace Pharm2U.Models.OrderDataViewModels
{
    /// <summary>
    /// This object assembles the various database values for the selected object.
    /// It's basically one huge table MERGE operation on multiple tables since there are no foreign keys
    /// currently used in the database.
    /// </summary>
    public class OrderDetailsViewModel : ObservableObject
    {
        #region Private Members
        private Pharmacy _mPharmacy;

        #endregion

        #region Public Properties

        /// <summary>
        /// The order data
        /// </summary>
        public P2U_Order Order { get; set; }

        /// <summary>
        /// The order's customer data
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// The order's related food order items
        /// </summary>
        public ObservableCollection<P2U_OrderFood> OrderFood { get; set; }

        /// <summary>
        /// The assembled food object that is a merge of the P2U_Order and P2U_Food tables.
        /// This will combine the order number, quantity, and pricing information with the item name and description
        /// </summary>
        public ObservableCollection<Food> FoodList { get; set; }

        /// <summary>
        /// The order's OTCMed med items
        /// </summary>
        public ObservableCollection<P2U_OrderOTCMeds> OrderOTCMeds { get; set; }


        /// <summary>
        /// The assembled food object that is a merge of the P2U_Order and P2U_OTCMedication tables.
        /// This will combine the order number, quantity, and pricing information with the item name and description
        /// </summary>
        public ObservableCollection<OTCMed> OTCMedsList { get; set; }

        /// <summary>
        /// The assembled pharmacy object that contains the merged data for the Address and P2U_Pharmacy data
        /// </summary>
        public Pharmacy Pharmacy {
            get => _mPharmacy; 
            set {
                if (value == _mPharmacy)
                    return;

                _mPharmacy = value;

                OnPropertyChanged("Pharmacy");
            }
        }


        /// <summary>
        /// Returns the subtotal price not including tax.
        /// </summary>
        public decimal SubTotalPrice { get; set; }

        /// <summary>
        /// The total tax for the taxable items in the Food and OTCMed list
        /// </summary>
        public decimal TaxPrice { get; set; }

        /// <summary>
        /// The delivery price for this order
        /// </summary>
        public decimal? DeliveryPrice { get => Order.DeliveryCost; }

        /// <summary>
        /// The total price
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// The subtotal price as a string
        /// </summary>
        public string SubTotalPriceString
        {
            get => "$" + SubTotalPrice.ToString();
        }

        /// <summary>
        /// The tax price as a string
        /// </summary>
        public string TaxPriceString
        {
            get => "$" + TaxPrice.ToString();
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor that creates our full object viuew model
        /// </summary>
        /// <param name="num"></param>
        public OrderDetailsViewModel(int num)
        {
            // retrieve the data tables from the application view model
            IDataTables dt = IoC.IoCContainer.Get<ApplicationViewModel>().DataTables;

            // retrieve the specific order infromation for the specified order
            bool recordFound = false;

            #region Order Data

            Order = new P2U_Order();
            foreach (P2U_Order item in dt.OrderData.Data)
            {
                if (item.ItemID == num)
                {
                    recordFound = true;
                    Order = item;
                    break;
                }
            }
            #endregion

            // If no order was found, there shouldnt be any related data in the database
            if (!recordFound)
            {
                MessageBox.Show("No matching record for Order #" + num + "was found");
                return;
            }

            #region Customer Data
            // Otherwise, proceed with getting the customer data
            foreach (P2U_Customer item in dt.CustomerData.Data)
            {
                if (item.ItemID == Order.CustomerID)
                {
                    Customer = new Customer(item);
                    break;
                }
            }
            #endregion

            #region Food Data
            // Now get the food order data
            OrderFood = new ObservableCollection<P2U_OrderFood>();
            foreach (P2U_OrderFood item in dt.OrderFoodData.Data)
            {
                // Does a food order's order ID entry match the the current order ID?
                if (item.OrderID == Order.ItemID)
                {
                    // Add the food items to the list.
                    OrderFood.Add(item);
                }
            }

            FoodList = new ObservableCollection<Food>();
            foreach (P2U_OrderFood item in OrderFood)
            {
                foreach (P2U_Food food in dt.FoodData.Data)
                {
                    if (item.FoodID == food.ItemID)
                    {

                        // Get the name and description of the item
                        FoodList.Add(new Food(item, food));
                        break;
                    }
                }
            }
            #endregion

            #region OTCMed Data
            // Now get the food order data
            OrderOTCMeds = new ObservableCollection<P2U_OrderOTCMeds>();
            foreach (P2U_OrderOTCMeds item in dt.OrderOTCMedData.Data)
            {
                // Does a food order's order ID entry match the the current order ID?
                if (item.OrderID == Order.ItemID)
                {
                    // Add the food items to the list.
                    OrderOTCMeds.Add(item);
                }
            }

            OTCMedsList = new ObservableCollection<OTCMed>();
            foreach (P2U_OrderOTCMeds item in OrderOTCMeds)
            {
                foreach (P2U_OTCMedication otcmed in dt.OTCMedData.Data)
                {
                    if (item.OTCMedID == otcmed.ItemID)
                    {
                        // Get the name and description of the item
                        OTCMedsList.Add(
                            new OTCMed(otcmed.ItemID,
                                     otcmed.Name,
                                     otcmed.Description,
                                     item.Qty,
                                     item.Price,
                                     item.Taxable
                                     ));
                        break;
                    }
                }
            }
            #endregion

            #region Pharmacy Data
            // Otherwise, proceed with getting the customer data
            foreach (P2U_Pharmacy item in dt.PharmacyData.Data)
            {
                if (item.ItemID == Order.PharmacyID)
                {
                    Pharmacy = new Pharmacy(item);
                    break;
                }
            }

            SubTotalPrice = ComputeSubtotal();
            TaxPrice = ComputeTax();

            #endregion
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Compute the subtotal of food and otc med items
        /// </summary>
        /// <returns></returns>
        private decimal ComputeSubtotal()
        {
            decimal sum = 0.00m;

            foreach (Food item in FoodList)
            {
                sum += item.Qty * item.Price;
            }

            foreach (OTCMed item in OTCMedsList)
            {
                sum += item.Qty * item.Price;
            }

            return sum;
        }

        /// <summary>
        /// Compute the tax for taxable food and otc med items
        /// </summary>
        /// <returns></returns>
        private decimal ComputeTax()
        {
            decimal sum = 0.00m;

            foreach (Food item in FoodList)
            {
                if (item.Taxable == true)
                    sum += item.Qty * item.Price;
            }

            foreach (OTCMed item in OTCMedsList)
            {
                if (item.Taxable == true)
                    sum += item.Qty * item.Price;
            }

            double taxrate = (Order.Tax >= 0) ? (double)Order.Tax / 100.0 : 1.00 / 100.0;
            sum *= (decimal)taxrate;
            return sum;
        }
        #endregion
    };

}
