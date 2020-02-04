using Pharm2U.Services.Data.EntityFramework;
using System;

namespace Pharm2U.Models.Data
{
    public class Customer
    {
        #region Public Properties

        /// <summary>
        /// Fields taken from P2U_Customer since multiple inheritance isn't allowed.
        /// </summary>
        public int ItemID { get; set; }
        public Nullable<int> ItemCreatedBy { get; set; }
        public Nullable<System.DateTime> ItemCreatedWhen { get; set; }
        public Nullable<int> ItemModifiedBy { get; set; }
        public Nullable<System.DateTime> ItemModifiedWhen { get; set; }
        public Nullable<int> ItemOrder { get; set; }
        public System.Guid ItemGUID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactMethod { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public string Zip { get; set; }
        public string AddressType { get; set; }

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
        public Customer(int id, string first, string last, string address, string phone, string email)
        {
            ItemCreatedWhen = DateTime.Now;
            ItemModifiedWhen = DateTime.Now;
            ItemID = id;
            FirstName = first;
            LastName = last;
            StreetAddress = address;
            Email = email;
            Phone = phone;
        }

        /// <summary>
        /// Constructor that takes an Entitity Framework customer type and creates a Customer model object
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
