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
    
    public partial class HealthCare_News
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string PhotoPath { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public int Admin_ID { get; set; }
        public Nullable<bool> Approved { get; set; }
        public Nullable<int> Approved_By { get; set; }
    }
}