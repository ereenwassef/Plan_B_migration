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
    
    public partial class Distributors_Diploma
    {
        public int ID { get; set; }
        public Nullable<int> Distributor_ID { get; set; }
        public Nullable<int> Diploma_Details_ID { get; set; }
        public Nullable<System.DateTime> Registration_Date { get; set; }
        public Nullable<int> Grade_ID { get; set; }
        public string Notes { get; set; }
    }
}
