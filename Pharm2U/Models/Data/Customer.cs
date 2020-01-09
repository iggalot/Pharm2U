namespace Pharm2U.Models.Data
{
    public class Customer
    {
        public int Id { get; private set; }
        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; private set; }

        /// <summary>
        /// Billing Addresss
        /// </summary>
        public string BillingAddress { get; private set; }

        /// <summary>
        /// Delivery Addresss
        /// </summary>
        public string DeliveryAddress { get; private set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string Phone { get; private set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="id">id of record</param>
        /// <param name="first">first name</param>
        /// <param name="last">last name</param>
        /// <param name="billing">billing address</param>
        /// <param name="delivery">delivery address</param>
        /// <param name="phone">phone number</param>
        public Customer(int id, string first, string last, string billing, string delivery, string phone)
        {
            Id = id;
            FirstName = first;
            LastName = last;
            BillingAddress = billing;
            DeliveryAddress = delivery;
            Phone = phone;
        }

        /// <summary>
        /// Display method for this class
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            string str = string.Empty;

            str += "-- Customer ID: " + Id.ToString() + "   First: " + FirstName + "   Last: " + LastName + 
                "   Billing: " + BillingAddress + "   Delivery: " + DeliveryAddress + "   Phone: " + Phone;

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
