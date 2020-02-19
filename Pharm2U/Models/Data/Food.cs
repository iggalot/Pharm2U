namespace Pharm2U.Models.Data
{
    /// <summary>
    /// This object is used to compile the food object record after all the tables have been searched and merged.
    /// </summary>
    public class Food
    {
        /// <summary>
        /// Id number
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the food
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The quantity of this item
        /// </summary>
        public int Qty { get; set; }

        /// <summary>
        /// Type of food (solid, liquid, jello?)
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

        public Food(int id, string name, string description, int qty, decimal price, bool taxable, string type)
        {
            Id = id;
            Name = name;
            Description = description;
            Qty = qty;
            Price = price;
            Taxable = taxable;
            Type = type;
        }

        /// <summary>
        /// Display method for this class
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            string str = string.Empty;

            str += "---- Food ID: " + Id.ToString() + "   Name : " + Name + "   Type: " + Type;

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
