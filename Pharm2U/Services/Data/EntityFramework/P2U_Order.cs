//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pharm2U.Services.Data.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class P2U_Order
    {
        public int ItemID { get; set; }
        public Nullable<int> ItemCreatedBy { get; set; }
        public Nullable<System.DateTime> ItemCreatedWhen { get; set; }
        public Nullable<int> ItemModifiedBy { get; set; }
        public Nullable<System.DateTime> ItemModifiedWhen { get; set; }
        public Nullable<int> ItemOrder { get; set; }
        public System.Guid ItemGUID { get; set; }
        public int CustomerID { get; set; }
        public Nullable<int> PharmacyID { get; set; }
        public Nullable<int> DeliveryCompanyID { get; set; }
        public string ProviderUsername { get; set; }
        public string Status { get; set; }
        public string DeliveryWindow { get; set; }
        public string DeliveryInstructions { get; set; }
        public Nullable<decimal> DeliveryCost { get; set; }
        public Nullable<decimal> FoodCost { get; set; }
        public Nullable<decimal> OTCMedCost { get; set; }
        public Nullable<decimal> PrescriptionCost { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> TotalCost { get; set; }
        public string AuthCode { get; set; }
        public string TransactionKey { get; set; }
        public string CardNumber { get; set; }
        public Nullable<System.DateTime> OrderInitiatedWhen { get; set; }
        public Nullable<System.DateTime> NewOrderCreatedWhen { get; set; }
        public Nullable<System.DateTime> ReadyForPaymentWhen { get; set; }
        public Nullable<System.DateTime> ReadyForPackagingWhen { get; set; }
        public Nullable<System.DateTime> ReadyForPickupWhen { get; set; }
        public Nullable<System.DateTime> OutForDeliveryWhen { get; set; }
        public Nullable<System.DateTime> DeliveredWhen { get; set; }
        public Nullable<System.DateTime> CanceledWhen { get; set; }
        public string CanceledReason { get; set; }
        public Nullable<System.DateTime> ReturnedWhen { get; set; }
        public string ReturnedReason { get; set; }
    }
}
