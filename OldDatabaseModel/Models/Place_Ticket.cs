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
    
    public partial class Place_Ticket
    {
        public int ID { get; set; }
        public Nullable<int> Place_ID { get; set; }
        public Nullable<int> Distributor_ID { get; set; }
        public string Ticket_Type { get; set; }
        public string Ticket_Text { get; set; }
        public Nullable<bool> Is_Solved { get; set; }
        public string Other_Phone { get; set; }
        public Nullable<int> Health_Type_ID { get; set; }
        public Nullable<System.DateTime> Ticket_Date { get; set; }
        public Nullable<System.DateTime> Closing_Date { get; set; }
    }
}