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
    
    public partial class Video
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public string Code { get; set; }
        public Nullable<int> Admin_ID { get; set; }
        public Nullable<System.DateTime> Date_Modified { get; set; }
        public Nullable<bool> Is_Active { get; set; }
        public Nullable<int> Views_Count { get; set; }
        public Nullable<int> Gallery_ID { get; set; }
    }
}