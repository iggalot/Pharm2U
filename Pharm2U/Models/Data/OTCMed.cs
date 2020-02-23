namespace Pharm2U.Models.Data
{
    /// <summary>
    /// A class for containing the OTC med object.
    /// This is built from a merge of the P2U_OrderOTCMed table and the P2U_Medications
    /// </summary>
    public class OTCMed
    {
        #region Public Properties
        /// <summary>
        /// Id number
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the OTC item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The quantity of this item
        /// </summary>
        public int Qty { get; set; }

        /// <summary>
        /// Type of OTC item (solid, liquid, jello?)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The description of the food item
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Is this item taxable
        /// </summary>
        public bool Taxable { get; set; }

        /// <summary>
        /// The current price of the item
        /// </summary>
        public decimal Price { get; set; }


        /// <summary>
        /// Returns the total price
        /// </summary>
        public decimal TotalPrice { get; set; }


        /// <summary>
        /// Creates the Qty and Unit Price string for this item (e.g.: 2 @ $2.22)
        /// </summary>
        public string QtyAndUnitPriceString
        {
            get => Qty.ToString() + " @ $" + Price.ToString();
        }

        /// <summary>
        /// The total price as a string
        /// </summary>
        public string TotalPriceString
        {
            get => "$" + TotalPrice.ToString();
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">Name of the item</param>
        /// <param name="description">Description of the item</param>
        /// <param name="qty">Qty of the item in the order</param>
        /// <param name="price">Price of the items in the order</param>
        /// <param name="taxable">Is the item taxable</param>
        public OTCMed(int id, string name, string description, int qty, decimal price, bool taxable)
        {
            Id = id;
            Name = name;
            Description = description;
            Qty = qty;
            Price = price;
            Taxable = taxable;

            TotalPrice = Qty * Price;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Display method for this class
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            string str = string.Empty;

            str += "---- OTCMed ID: " + Id.ToString() + "   Name : " + Name + "   Type: " + Type;

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
        #endregion
    }
}
