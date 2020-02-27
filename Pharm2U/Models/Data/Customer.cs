using Pharm2U.Services.Data.EntityFramework;
using Pharm2U.ViewModels.InfoiViewModels;
using System;

namespace Pharm2U.Models.Data
{
    public class Customer : P2U_Customer
    {
        #region Public Properties

        // Returns the city, state, info for the given zip
        public AddressDataViewModel AddressInfo { get; set; } = null;
        #endregion

        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">ID number of this record</param>
        /// <param name="first">First name</param>
        /// <param name="last"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        public Customer(int id, string first, string last, string address, string phone, string email, string zip, string type)
        {
            ItemCreatedWhen = DateTime.Now;
            ItemModifiedWhen = DateTime.Now;
            ItemID = id;
            FirstName = first;
            LastName = last;
            StreetAddress = address;
            Email = email;
            Phone = phone;
            Zip = zip;
            AddressType = type;

            // Create the address data object for the customer
            AddressInfo = new AddressDataViewModel(address, zip);
        }

        /// <summary>
        /// Constructor that takes an Entitity Framework customer type and creates our Customer model object
        /// </summary>
        /// <param name=""></param>
        public Customer(P2U_Customer customer)
        {
            ItemID = customer.ItemID;
            ItemCreatedBy = customer.ItemCreatedBy;
            ItemCreatedWhen = customer.ItemCreatedWhen;
            ItemModifiedBy = customer.ItemModifiedBy;
            ItemModifiedWhen = customer.ItemModifiedWhen;
            ItemOrder = customer.ItemOrder;
            ItemGUID = customer.ItemGUID;
            FirstName = customer.FirstName;
            LastName = customer.LastName;
            ContactMethod = customer.ContactMethod;
            Phone = customer.Phone;
            Email = customer.Email;
            StreetAddress = customer.StreetAddress;
            Zip = customer.Zip;
            AddressType = customer.AddressType;

            // Create the address data object for the customer
            AddressInfo = new AddressDataViewModel(StreetAddress, Zip);
        }

        #endregion

        /// <summary>
        /// Display method for this class
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            string str = string.Empty;

            str += "-- CustID: " + ItemID.ToString() + "   First: " + FirstName + "   Last: " + LastName + 
                "   Billing: " + StreetAddress + "   Phone: " + Phone + "   Email: " + Email;

            return str;
        }
        
        /// <summary>
        /// Override of the ToString method to print out class information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Display();
        }
    }
}
