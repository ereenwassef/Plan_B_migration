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
    
    public partial class Point
    {
        public int ID { get; set; }
        public Nullable<int> Distributor_ID { get; set; }
        public Nullable<int> From_Distributor { get; set; }
        public Nullable<int> Point_Count { get; set; }
        public string Side { get; set; }
        public string Point_Type { get; set; }
        public Nullable<System.DateTime> Point_Date { get; set; }
        public Nullable<bool> Is_Calculated { get; set; }
        public Nullable<System.DateTime> Calculation_Date { get; set; }
        public Nullable<int> Point_Level { get; set; }
        public Nullable<bool> Is_Offer { get; set; }
        public Nullable<bool> Is_Upgrade { get; set; }
        public Nullable<bool> Is_Flashed { get; set; }
        public Nullable<System.DateTime> Flash_Date { get; set; }
    }
}