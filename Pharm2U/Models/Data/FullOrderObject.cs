﻿using Pharm2U.Services.Data;
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
        #region Public Properties

        /// <summary>
        /// The order data
        /// </summary>
        public P2U_Order Order { get; set; }

        /// <summary>
        /// The order's customer data
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// The order's related food order items
        /// </summary>
        public ObservableCollection<P2U_OrderFood> OrderFood { get; set; }

        /// <summary>
        /// The assembled food object that is a merge of the P2U_Order and P2U_Food tables.
        /// This will combine the order number, quantity, and pricing information with the item name and description
        /// </summary>
        public ObservableCollection<Food> FoodList { get; set; }

        /// <summary>
        /// The OTCMed med items
        /// </summary>
        public ObservableCollection<P2U_OrderOTCMeds> OrderOTCMeds { get; set; }

        /// <summary>
        /// The assembled food object that is a merge of the P2U_Order and P2U_OTCMed tales
        /// </summary>
        /// <param name="num"></param>

        /// <summary>
        /// The assembled food object that is a merge of the P2U_Order and P2U_OTCMedication tables.
        /// This will combine the order number, quantity, and pricing information with the item name and description
        /// </summary>
        public ObservableCollection<OTCMed> OTCMedsList { get; set; }

        public Pharmacy Pharmacy { get; set; }
        #endregion

        #region Constructor
        public FullOrderObject(int num)
        {
            // retrieve the data tables from the application view model
            IDataTables dt = IoC.IoCContainer.Get<ApplicationViewModel>().DataTables;

            // retrieve the specific order infromation for the specified order
            bool recordFound = false;

            #region Order Data

            Order = new P2U_Order();
            foreach (P2U_Order item in dt.OrderData.Data)
            {
                if (item.ItemID == num)
                {
                    recordFound = true;
                    Order = item;
                    break;
                }
            }
            #endregion

            // If no order was found, there shouldnt be any related data in the daatabase
            if (!recordFound)
            {
                MessageBox.Show("No matching record for Order #" + num + "was found");
                return;
            }

            #region Customer Data
            // Otherwise, proceed with getting the customer data
            foreach (P2U_Customer item in dt.CustomerData.Data)
            {
                if (item.ItemID == Order.CustomerID)
                {
                    Customer = new Customer(item);
                    break;
                }
            }
            #endregion

            #region Food Data
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
                foreach (P2U_Food food in dt.FoodData.Data)
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
                        break;
                    }
                }
            }
            #endregion

            #region OTCMed Data
            // Now get the food order data
            OrderOTCMeds = new ObservableCollection<P2U_OrderOTCMeds>();
            foreach (P2U_OrderOTCMeds item in dt.OrderOTCMedData.Data)
            {
                // Does a food order's order ID entry match the the current order ID?
                if (item.OrderID == Order.ItemID)
                {
                    // Add the food items to the list.
                    OrderOTCMeds.Add(item);
                }
            }

            OTCMedsList = new ObservableCollection<OTCMed>();
            foreach (P2U_OrderOTCMeds item in OrderOTCMeds)
            {
                foreach (P2U_OTCMedication otcmed in dt.OTCMedData.Data)
                {
                    if (item.OTCMedID == otcmed.ItemID)
                    {
                        // Get the name and description of the item
                        OTCMedsList.Add(
                            new OTCMed(otcmed.ItemID,
                                     otcmed.Name,
                                     otcmed.Description,
                                     item.Qty,
                                     item.Price,
                                     item.Taxable
                                     ));
                        break;
                    }
                }
            }
            #endregion

            #region Pharmacy Data
            // Otherwise, proceed with getting the customer data
            foreach (P2U_Pharmacy item in dt.PharmacyData.Data)
            {
                if (item.ItemID == Order.PharmacyID)
                {
                    Pharmacy = new Pharmacy(item);
                    break;
                }
            }
            #endregion
        }

        #endregion
    };

}
