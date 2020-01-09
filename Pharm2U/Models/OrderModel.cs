using Pharm2U.Models.Data;
using Pharm2U.Utilities;
using System;
using System.Collections.ObjectModel;

namespace Pharm2U.Models
{
    /// <summary>
    /// Data Model for an Order
    /// </summary>
    public class OrderModel : ObservableObject
    {
        #region Public Properties
        /// <summary>
        /// Id number for this ordert
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Customer data for who placed this order
        /// </summary>
        public Customer Customer { get; private set; }

        /// <summary>
        /// Food items requested
        /// </summary>
        public ObservableCollection<Food> FoodItems { get; private set; } = new ObservableCollection<Food>();

        /// <summary>
        /// OTC items requested
        /// </summary>
        public ObservableCollection<OTC> OTCItems { get; private set; } = new ObservableCollection<OTC>();
        #endregion

        #region Default constructors
        /// <summary>
        /// Parameterless constructor (for templating)
        /// </summary>
        public OrderModel()
        {

        }

        /// <summary>
        /// Standard constructor (with parameters)
        /// </summary>
        /// <param name="id">order number</param>
        /// <param name="customer">customer class object</param>
        /// <param name="food_items">food items list</param>
        /// <param name="otc_items">otc items list</param>
        public OrderModel(int id, Customer customer, ObservableCollection<Food> food_items, ObservableCollection<OTC> otc_items)
        {
            Id = id;
            Customer = customer;
            FoodItems = food_items;
            OTCItems = otc_items;

        }
        #endregion

        #region Public Methods

        public string Display()
        {
            string str = String.Empty;

            str += "OrderID: " + Id.ToString() + "\n";
            str += Customer.ToString() + "\n";

            str += $"-- Food Items ({FoodItems.Count}): \n";
            foreach (Food item in FoodItems)
                str += item.ToString() + "\n";

            str += $"-- OTC Items ({FoodItems.Count}): \n";
            foreach (OTC item in OTCItems)
                str += item.ToString() + "\n";

            return str;
        }

        public override string ToString()
        {
            return this.Display();
        }
        #endregion
    }
}
