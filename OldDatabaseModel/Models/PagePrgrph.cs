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
    
    public partial class PagePrgrph
    {
        public long PagePrgrphID { get; set; }
        public string PagePrgrphTitle { get; set; }
        public string PagePrgrphTitleIcon { get; set; }
        public string PagePrgrphDesc { get; set; }
        public string PagePrgrphPhoto { get; set; }
        public Nullable<int> PagePrgrphPhotoLocID { get; set; }
        public System.DateTime PagePrgrphDateAdd { get; set; }
        public int PagePrgrphOrder { get; set; }
        public long FKPageID { get; set; }
    }
}
