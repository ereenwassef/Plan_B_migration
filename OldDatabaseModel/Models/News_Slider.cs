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
    
    public partial class News_Slider
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Title_Ar { get; set; }
        public string Image_Small_Path { get; set; }
        public string Image_Large_Path { get; set; }
        public string Image_alt { get; set; }
        public string News_Link { get; set; }
        public string Image_Small_Desc { get; set; }
        public Nullable<bool> Is_Active { get; set; }
    }
}