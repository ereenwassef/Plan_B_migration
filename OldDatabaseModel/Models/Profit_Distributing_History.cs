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
    
    public partial class Profit_Distributing_History
    {
        public int ID { get; set; }
        public Nullable<int> Distributor_ID { get; set; }
        public Nullable<int> Status_ID { get; set; }
        public Nullable<decimal> Profit_Rate { get; set; }
        public Nullable<int> Membership_ID { get; set; }
        public Nullable<int> From_Distributor_ID { get; set; }
        public Nullable<bool> Is_Sponser { get; set; }
        public Nullable<System.DateTime> Activation_Date { get; set; }
    }
}
