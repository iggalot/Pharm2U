namespace Pharm2U.Models.Data
{
    public class OTCMed
    {
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

        public OTCMed(int id, string name, string description, int qty, decimal price, bool taxable)
        {
            Id = id;
            Name = name;
            Description = description;
            Qty = qty;
            Price = price;
            Taxable = taxable;
        }

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
    }
}
