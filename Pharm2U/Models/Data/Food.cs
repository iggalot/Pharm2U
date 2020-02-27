using Pharm2U.Services.Data.EntityFramework;
using System;

namespace Pharm2U.Models.Data
{
    /// <summary>
    /// This object is used to compile the food object record after all the tables have been searched and merged.
    /// </summary>
    public class Food : P2U_OrderFood
    {
        private decimal _totalPrice = 0.00m;

        /// <summary>
        /// Name of the food item (from P2U_Food)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the food item (from P2U_Food)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The type of the food. (from P2U_Food)
        /// </summary>
        public string Type { get; set; }

        /// Returns the total price
        /// </summary>
        public decimal TotalPrice { get; set; }


        /// <summary>
        /// Creates the Qty and Unit Price string for this item (e.g.: 2 @ $2.22)
        /// </summary>
        public string QtyAndUnitPriceString
        {
            get => Qty.ToString() + " @ $" + this.Price.ToString();
        }

        /// <summary>
        /// The total price as a string
        /// </summary>
        public string TotalPriceString
        {
            get => "$" + TotalPrice.ToString();
        }

        #region Constructor
        public Food(int id, string name, string description, int qty, decimal price, bool taxable, string type)
        {
            ItemCreatedWhen = DateTime.Now;
            ItemModifiedWhen = DateTime.Now;
            ItemID = id;
            Name = name;
            Description = description;
            Qty = qty;
            Price = price;
            Taxable = taxable;
            Type = type;

            TotalPrice = Qty * Price;
        }

        /// <summary>
        /// Constructor thtat takes a P2_Food and P2U_OrderFood EntityFramework object
        /// /// and creates our Food object record for this application.
        /// </summary>
        /// <param name="food"></param>
        /// <param name="orderFood"></param>
        public Food(P2U_OrderFood orderFood, P2U_Food food)
        {
            ItemID = orderFood.ItemID;
            ItemCreatedWhen = orderFood.ItemCreatedWhen;
            ItemCreatedBy = orderFood.ItemCreatedBy;
            ItemModifiedWhen = orderFood.ItemModifiedWhen;
            ItemModifiedBy = orderFood.ItemModifiedBy;
            ItemOrder = orderFood.ItemOrder;
            ItemGUID = orderFood.ItemGUID;

            Name = food.Name;
            Description = food.Description;
            Qty = orderFood.Qty;
            Price = orderFood.Price;
            Taxable = orderFood.Taxable;
            Type = food.Type;

            TotalPrice = Qty * Price;
        }
        #endregion

        /// <summary>
        /// Display method for this class
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            string str = string.Empty;

            str += "---- Food ID: " + ItemID.ToString() + "   Name : " + Name + "   Type: " + Type;

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
