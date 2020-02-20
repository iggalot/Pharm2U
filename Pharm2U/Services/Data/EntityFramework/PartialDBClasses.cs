using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pharm2U.Services.Data.EntityFramework
{
    /// <summary>
    /// Partial class definitions for the EntityFramework class objects.  Needed to create a non DB constructor,
    /// and to provide additional methodology
    /// </summary>

    #region Order Wrapper
    public partial class P2U_Order
    {
        /// <summary>
        /// Empty constructor used for generic contructions in template functions
        /// </summary>
        public P2U_Order()
        {

        }
        /// <summary>
        /// Constructor accepting parameters
        /// </summary>
        public P2U_Order(int id, int customer_id, int pharm_id, int deliv_id, string status)
        {
            this.ItemID = id;
            this.ItemCreatedBy = 100;
            this.ItemCreatedWhen = DateTime.Now;
            this.ItemModifiedBy = 100;
            this.ItemModifiedWhen = DateTime.Now;
            this.ItemOrder = 1;
            this.ItemGUID = Guid.NewGuid();
            this.CustomerID = customer_id;
            this.PharmacyID = pharm_id;
            this.DeliveryCompanyID = deliv_id;
            this.ProviderUsername = "Provider name";
            this.Status = status;
            this.DeliveryWindow = "8:00AM - 12:00PM";
            this.DeliveryInstructions = "Left turn at albequerque";
            this.DeliveryCost = (decimal)1.00;
            this.FoodCost = (decimal)2.00;
            this.OTCMedCost = (decimal)3.00;
            this.PrescriptionCost = (decimal)3.00;
            this.Tax = (decimal)1.00;
            this.TotalCost = (decimal)10.00;
            this.AuthCode = "auth code";
            this.TransactionKey = "trans key";
            this.CardNumber = "1234-5678-1234-5678";
            this.OrderInitiatedWhen = DateTime.Now;
            this.NewOrderCreatedWhen = DateTime.Now;
            this.ReadyForPaymentWhen = DateTime.Now;
            this.ReadyForPackagingWhen = DateTime.Now;
            this.ReadyForPickupWhen = DateTime.Now;
            this.OutForDeliveryWhen = DateTime.Now;
            this.DeliveredWhen = DateTime.Now;
            this.CanceledWhen = DateTime.Now;
            this.CanceledReason = "N/A";
            this.ReturnedWhen = DateTime.Now;
            this.ReturnedReason = "N/A";
        }

        /// <summary>
        /// Display the order information information
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            string str = String.Empty;

            str += "-----------------------------------------------------\n";
            str += "OrderID: " + this.ItemID.ToString() + "   Status: " + Status + "\n";
            str += "-- Cust. #: " + CustomerID.ToString() + "    ";
            str += "-- Pharm. ID #: " + PharmacyID.ToString() + "    ";
            str += "-- Deliv Co. #: " + DeliveryCompanyID.ToString() + "    ";
            str += "\n";

            //str += $"-- Food Items ({FoodItems.Count}): \n";
            //foreach (Food item in FoodItems)
            //    str += item.ToString() + "\n";

            //str += $"-- OTCMed Items ({OTCItems.Count}): \n";
            //foreach (OTCMed item in OTCItems)
            //    str += item.ToString() + "\n";

            return str;
        }

        public override string ToString()
        {
            return this.Display();
        }
    };
    #endregion

    #region Customer Wrappers
    public partial class P2U_Customer
    {
        /// <summary>
        /// An empty constructor for templating
        /// </summary>
        public P2U_Customer()
        {

        }

        /// <summary>
        /// Constructor for mock data
        /// </summary>
        /// <param name="id">Id number</param>
        /// <param name="first">First name</param>
        /// <param name="last">Last name</param>
        /// <param name="address">Street address</param>
        /// <param name="city">City</param>
        /// <param name="state">State</param>
        /// <param name="zip">Zip code</param>
        /// <param name="phone">Phone number</param>
        /// <param name="email">Email address</param>
        public P2U_Customer(int id, string first, string last, string address, string city, string state, string zip, string phone, string email)
        {
            ItemID = id;
            ItemCreatedBy = null;
            ItemCreatedWhen = DateTime.Now;
            ItemModifiedBy = null;
            ItemModifiedWhen = DateTime.Now;
            ItemOrder = null;
            ItemGUID = Guid.NewGuid();
            FirstName = first;
            LastName = last;
            ContactMethod = "By Phone";
            Phone = phone;
            Email = email;
            StreetAddress = address + ", " + city + ", " + state;
            Zip = zip;
            AddressType = address;
        }

        /// <summary>
        /// Override of ToString for displaying purposes
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Display();
        }

        /// <summary>
        /// Function to display a Customer record.
        /// </summary>
        /// <returns></returns>
        private string Display()
        {
            string str = String.Empty;
            str += "--------\n";
            str += "CustID: " + this.ItemID + ": " + "\n";
            str += this.LastName + ", " + this.FirstName + "\n" + this.StreetAddress + ", " + this.Zip + "\n";
            str += this.Phone + "   " + this.Email + "\n";
            return str;
        }
    };
    #endregion

    #region OrderFood Wrapper
    public partial class P2U_OrderFood
    {
        /// <summary>
        /// Empty constructor used for generic contructions in template functions
        /// </summary>
        public P2U_OrderFood()
        {

        }
        /// <summary>
        /// Constructor accepting parameters
        /// </summary>
        public P2U_OrderFood(int id, int food_id, int order_id, decimal price, int qty)
        {
            this.ItemID = id;
            this.ItemCreatedBy = 100;
            this.ItemCreatedWhen = DateTime.Now;
            this.ItemModifiedBy = 100;
            this.ItemModifiedWhen = DateTime.Now;
            this.ItemOrder = 1;
            this.ItemGUID = Guid.NewGuid();
            this.FoodID = food_id;
            this.OrderID = order_id;
            this.Price = price;
            this.Qty = qty;
            this.Taxable = false;
        }

        /// <summary>
        /// Display the order's food information
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            string str = String.Empty;

            str += "-----------------------------------------------------\n";
            str += "OrderFoodID: " + this.ItemID.ToString() + "\n";
            str += "-- Order. #: " + this.OrderID.ToString() + "    ";
            str += "Qty: " + this.Qty + "   ";
            str += "Food. ID #: " + this.FoodID.ToString() + "    ";
            str += "Price: " + String.Format("{0:0.00}", this.Price) + "    ";
            str += "Taxable: " + (this.Taxable == true ? "true" : "false") + "    ";
            str += "\n";

            return str;
        }

        public override string ToString()
        {
            return this.Display();
        }
    };
    #endregion

    #region Food Wrapper
    public partial class P2U_Food
    {
        /// <summary>
        /// Empty constructor used for generic contructions in template functions
        /// </summary>
        public P2U_Food()
        {

        }
        /// <summary>
        /// Constructor accepting parameters
        /// </summary>
        public P2U_Food(int id, string name, string description, decimal price, bool taxable, string type)
        {
            this.ItemID = id;
            this.ItemCreatedBy = 100;
            this.ItemCreatedWhen = DateTime.Now;
            this.ItemModifiedBy = 100;
            this.ItemModifiedWhen = DateTime.Now;
            this.ItemOrder = 1;
            this.ItemGUID = Guid.NewGuid();
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Taxable = taxable;
            this.Type = type;
        }

        /// <summary>
        /// Display the food information information
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            string str = String.Empty;

            str += "-----------------------------------------------------\n";
            str += "FoodID: " + this.ItemID.ToString() + "   " + this.Name + " : " + this.Description + "\n";
            str += "Price: " + String.Format("{0:0.00}", this.Price) + "    ";
            str += "Taxable: " + (this.Taxable == true ? "true" : "false") + "    ";
            str += "Type: " + this.Type + "\n";
            str += "\n";

            return str;
        }

        public override string ToString()
        {
            return this.Display();
        }
    };
    #endregion


    #region OrderOTCMed Wrapper
    public partial class P2U_OrderOTCMeds
    {
        /// <summary>
        /// Empty constructor used for generic contructions in template functions
        /// </summary>
        public P2U_OrderOTCMeds()
        {

        }
        /// <summary>
        /// Constructor accepting parameters
        /// </summary>
        public P2U_OrderOTCMeds(int id, int otcmed_id, int order_id, decimal price, int qty)
        {
            this.ItemID = id;
            this.ItemCreatedBy = 100;
            this.ItemCreatedWhen = DateTime.Now;
            this.ItemModifiedBy = 100;
            this.ItemModifiedWhen = DateTime.Now;
            this.ItemOrder = 1;
            this.ItemGUID = Guid.NewGuid();
            this.OTCMedID = otcmed_id;
            this.OrderID = order_id;
            this.Price = price;
            this.Qty = qty;
            this.Taxable = false;
        }

        /// <summary>
        /// Display the order's food information
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            string str = String.Empty;

            str += "-----------------------------------------------------\n";
            str += "OrderOTCMedID: " + this.ItemID.ToString() + "\n";
            str += "-- Order. #: " + this.OrderID.ToString() + "    ";
            str += "Qty: " + this.Qty + "   ";
            str += "OTCMed ID #: " + this.OTCMedID.ToString() + "    ";
            str += "Price: " + String.Format("{0:0.00}", this.Price) + "    ";
            str += "Taxable: " + (this.Taxable == true ? "true" : "false") + "    ";
            str += "\n";

            return str;
        }

        public override string ToString()
        {
            return this.Display();
        }
    };
    #endregion

    #region Food Wrapper
    public partial class P2U_OTCMedication
    {
        /// <summary>
        /// Empty constructor used for generic contructions in template functions
        /// </summary>
        public P2U_OTCMedication()
        {

        }
        /// <summary>
        /// Constructor accepting parameters
        /// </summary>
        public P2U_OTCMedication(int id, string name, string description, decimal price, bool taxable)
        {
            this.ItemID = id;
            this.ItemCreatedBy = 100;
            this.ItemCreatedWhen = DateTime.Now;
            this.ItemModifiedBy = 100;
            this.ItemModifiedWhen = DateTime.Now;
            this.ItemOrder = 1;
            this.ItemGUID = Guid.NewGuid();
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Taxable = taxable;
        }

        /// <summary>
        /// Display the food information information
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            string str = String.Empty;

            str += "-----------------------------------------------------\n";
            str += "OTCMedID: " + this.ItemID.ToString() + "   " + this.Name + " : " + this.Description + "\n";
            str += "Price: " + String.Format("{0:0.00}", this.Price) + "    ";
            str += "Taxable: " + (this.Taxable == true ? "true" : "false") + "    ";
            str += "\n";

            return str;
        }

        public override string ToString()
        {
            return this.Display();
        }
    };
    #endregion
}
