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
    
    public partial class Upgrade_Program_History
    {
        public int ID { get; set; }
        public Nullable<int> Distributor_ID { get; set; }
        public Nullable<int> Old_Program { get; set; }
        public Nullable<int> New_Program { get; set; }
        public Nullable<System.DateTime> Upgrade_Date { get; set; }
    }
}
