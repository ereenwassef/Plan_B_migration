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
    
    public partial class Cashing_Balance_Request
    {
        public int ID { get; set; }
        public Nullable<int> Distributor_ID { get; set; }
        public Nullable<System.DateTime> Request_Date { get; set; }
        public Nullable<decimal> Requested_Amount { get; set; }
        public Nullable<bool> Is_Paid { get; set; }
        public Nullable<int> Paid_By { get; set; }
        public Nullable<System.DateTime> Paid_Date { get; set; }
        public Nullable<int> Payment_Gov_ID { get; set; }
        public Nullable<bool> Un_Paid { get; set; }
        public Nullable<System.DateTime> Un_Paid_Date { get; set; }
    }
}