//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OldDatabaseModel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shipping_Details
    {
        public int ID { get; set; }
        public Nullable<int> Distributor_ID { get; set; }
        public Nullable<int> Delivery_Method { get; set; }
        public Nullable<decimal> Delivery_Cost { get; set; }
        public Nullable<System.DateTime> Request_Date { get; set; }
        public Nullable<System.DateTime> Shipping_Date { get; set; }
        public Nullable<System.DateTime> Delivery_Date { get; set; }
        public Nullable<bool> Is_Shipped { get; set; }
        public Nullable<bool> Is_Main_Shipping { get; set; }
        public Nullable<bool> Is_Paid { get; set; }
        public string Notes { get; set; }
        public string OrderNumber { get; set; }
        public Nullable<bool> Is_Delivered { get; set; }
    }
}
