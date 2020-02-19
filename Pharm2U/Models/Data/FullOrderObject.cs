using Pharm2U.Services.Data;
using Pharm2U.Services.Data.EntityFramework;
using Pharm2U.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;

namespace Pharm2U.Models.Data
{
    /// <summary>
    /// This object assembles the various database values for the selected object.
    /// It's basically one huge table MERGE operation on multiple tables since there are no foreign keys
    /// currently used in the database.
    /// </summary>
    public class FullOrderObject
    {
        public P2U_Order Order { get; set; }
        public P2U_Customer Customer { get; set; }
        public ObservableCollection<P2U_OrderFood> OrderFood { get; set; }

        public ObservableCollection<Food> FoodList { get; set; }

        public FullOrderObject(int num)
        {
            // retrieve the data tables from the application view model
            IDataTables dt = IoC.IoCContainer.Get<ApplicationViewModel>().DataTables;

            // retrieve the specific order infromation for the specified order
            bool recordFound = false;
            Order = new P2U_Order();
            foreach (P2U_Order item in dt.OrderData.Data)
            {
                if (item.ItemID == num)
                {
                    recordFound = true;
                    Order = item;
                }
            }

            // If no order was found, there shouldnt be any related date in the daatabase
            if (!recordFound)
            {
                MessageBox.Show("No matching record for Order #" + num + "was found");
                return;
            }

            // Otherwise, proceed with getting the customer data
            Customer = new P2U_Customer();
            foreach (P2U_Customer item in dt.CustomerData.Data)
            {
                if (item.ItemID == Order.CustomerID)
                {
                    MessageBox.Show("Customer #" + Order.CustomerID + " match found");
                    Customer = item;
                }
            }

            // Now get the food order data
            OrderFood = new ObservableCollection<P2U_OrderFood>();
            foreach (P2U_OrderFood item in dt.OrderFoodData.Data)
            {
                // Does a food order's order ID entry match the the current order ID?
                if (item.OrderID == Order.ItemID)
                {
                    // Add the food items to the list.
                    OrderFood.Add(item);
                }
            }

            FoodList = new ObservableCollection<Food>();
            foreach (P2U_OrderFood item in OrderFood)
            {
                foreach(P2U_Food food in dt.FoodData.Data)
                {
                    if (item.FoodID == food.ItemID)
                    {

                        // Get the name and description of the item
                        FoodList.Add(
                            new Food(food.ItemID,
                                     food.Name,
                                     food.Description,
                                     item.Qty,
                                     item.Price,
                                     item.Taxable,
                                     food.Type));
                    }
                }
            }
        }

    };

}
