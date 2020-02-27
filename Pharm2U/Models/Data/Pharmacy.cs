using Pharm2U.Services.Data.EntityFramework;
using Pharm2U.ViewModels.InfoiViewModels;
using System;

namespace Pharm2U.Models.Data
{
    public class Pharmacy
    {
        public int ItemID { get; set; }
        public Nullable<int> ItemCreatedBy { get; set; }
        public Nullable<System.DateTime> ItemCreatedWhen { get; set; }
        public Nullable<int> ItemModifiedBy { get; set; }
        public Nullable<System.DateTime> ItemModifiedWhen { get; set; }
        public Nullable<int> ItemOrder { get; set; }
        public System.Guid ItemGUID { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }

        // Returns the city, state, info for the given zip
        public AddressDataViewModel AddressInfo { get; set; } = null;
        public string Phone { get; set; }
        public string Zip { get; set; }

        public Nullable<decimal> UseGlobalPricing { get; set; }
        public Nullable<decimal> GlobalDeliveryPrice { get; set; }
        public Nullable<bool> UseMinDeliveryAmt { get; set; }
        public Nullable<decimal> MinDeliveryAmt { get; set; }
        public Nullable<int> OrderTimeout { get; set; }
        public Nullable<int> PaymentTimeout { get; set; }
        public string GLNumber { get; set; }
        public Nullable<int> DefaultDeliveryCompany{ get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public string OrderEmailAddress { get; set; }
        public string OrderEmailSubject { get; set; }


        #region Constructors
        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="id">ID number of this record</param>
        /// <param name="first">First name</param>
        /// <param name="last"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        public Pharmacy(int id, string name, string address, string phone, string zip, decimal deliv_price)
        {
            ItemCreatedWhen = DateTime.Now;
            ItemModifiedWhen = DateTime.Now;
            ItemID = id;
            Name = name;
            Address = address;
            Phone = phone;
            Zip = zip;

            GlobalDeliveryPrice = deliv_price;
            UseMinDeliveryAmt = true;
            MinDeliveryAmt = deliv_price;
            OrderTimeout = null;
            PaymentTimeout = null;
            GLNumber = "default GLNumer";
            DefaultDeliveryCompany = 0;
            TaxRate = 8.00m;
            OrderEmailAddress = "default order email address";
            OrderEmailSubject = "default order email subject";

            // Create the address data object for the customer
            AddressInfo = new AddressDataViewModel(address, zip);
        }

        /// <summary>
        /// Constructor that takes an Entitity Framework phjarmacy type and creates a Pharmacy model object
        /// </summary>
        /// <param name=""></param>
        public Pharmacy(P2U_Pharmacy pharmacy)
        {
            ItemID = pharmacy.ItemID;
            ItemCreatedBy = pharmacy.ItemCreatedBy;
            ItemCreatedWhen = pharmacy.ItemCreatedWhen;
            ItemModifiedBy = pharmacy.ItemModifiedBy;
            ItemModifiedWhen = pharmacy.ItemModifiedWhen;
            ItemOrder = pharmacy.ItemOrder;
            ItemGUID = pharmacy.ItemGUID;
            Name = pharmacy.Name;
            Address = pharmacy.Address;
            Phone = pharmacy.Phone;
            Zip = pharmacy.Zip;

            GlobalDeliveryPrice = pharmacy.GlobalDeliveryPrice;
            UseMinDeliveryAmt = pharmacy.UseMinDeliveryAmt;
            MinDeliveryAmt = pharmacy.MinDeliveryAmt;
            OrderTimeout = pharmacy.OrderTimeout;
            PaymentTimeout = pharmacy.PaymentTimeout;
            GLNumber = pharmacy.GLNumber;
            DefaultDeliveryCompany = pharmacy.DefaultDeliveryCompany;
            TaxRate = pharmacy.TaxRate;
            OrderEmailAddress = pharmacy.OrderEmailAddress;
            OrderEmailSubject = pharmacy.OrderEmailSubject;

            // Create the address data object for the customer
            AddressInfo = new AddressDataViewModel(Address, Zip);
        }

        #endregion

    }
}
