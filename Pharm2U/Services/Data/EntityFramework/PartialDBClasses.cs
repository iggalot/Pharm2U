using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pharm2U.Services.Data.EntityFramework
{
    /// <summary>
    /// Partial class definitions for the EntityFramework class objects.  Needed to create a non DB constructor,
    /// and to provide additional methodology
    /// </summary>
    public partial class P2U_Order
    {
        /// <summary>
        /// Empty constructor used for generic contructions in template functions
        /// </summary>
        public P2U_Order()
        {

        }
        /// <summary>
        /// Constructor accepting parameters
        /// </summary>
        public P2U_Order(int id, int customer_id, int pharm_id, int deliv_id, string status)
        {
            this.ItemID = id;
            this.ItemCreatedBy = 100;
            this.ItemCreatedWhen = DateTime.Now;
            this.ItemModifiedBy = 100;
            this.ItemModifiedWhen = DateTime.Now;
            this.ItemOrder = 1;
            this.ItemGUID = Guid.NewGuid();
            this.CustomerID = customer_id;
            this.PharmacyID = pharm_id;
            this.DeliveryCompanyID = deliv_id;
            this.ProviderUsername = "Provider name";
            this.Status = status;
            this.DeliveryWindow = "8:00AM - 12:00PM";
            this.DeliveryInstructions = "Left turn at albequerque";
            this.DeliveryCost = (decimal)1.00;
            this.FoodCost = (decimal)2.00;
            this.OTCMedCost = (decimal)3.00;
            this.PrescriptionCost = (decimal)3.00;
            this.Tax = (decimal)1.00;
            this.TotalCost = (decimal)10.00;
            this.AuthCode = "auth code";
            this.TransactionKey = "trans key";
            this.CardNumber = "1234-5678-1234-5678";
            this.OrderInitiatedWhen = DateTime.Now;
            this.NewOrderCreatedWhen = DateTime.Now;
            this.ReadyForPaymentWhen = DateTime.Now;
            this.ReadyForPackagingWhen = DateTime.Now;
            this.ReadyForPickupWhen = DateTime.Now;
            this.OutForDeliveryWhen = DateTime.Now;
            this.DeliveredWhen = DateTime.Now;
            this.CanceledWhen = DateTime.Now;
            this.CanceledReason = "N/A";
            this.ReturnedWhen = DateTime.Now;
            this.ReturnedReason = "N/A";
        }

        /// <summary>
        /// Display the information
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            string str = String.Empty;

            str += "OrderID: " + this.ItemID.ToString() + "\n";
            str +=  "-- " + CustomerID.ToString() + "\n";

            //str += $"-- Food Items ({FoodItems.Count}): \n";
            //foreach (Food item in FoodItems)
            //    str += item.ToString() + "\n";

            //str += $"-- OTC Items ({OTCItems.Count}): \n";
            //foreach (OTC item in OTCItems)
            //    str += item.ToString() + "\n";

            return str;
        }

        public override string ToString()
        {
            return this.Display();
        }

    }
}
