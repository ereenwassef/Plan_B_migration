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
    
    public partial class DynamicPage
    {
        public long PageID { get; set; }
        public string PageBrowserTitle { get; set; }
        public string PageMainTitle { get; set; }
        public string PageMainTitleIcon { get; set; }
        public string PageMainPrgrph { get; set; }
        public string PagePhotoMainPrgrph { get; set; }
        public Nullable<int> PagePhotoMainPrgrphLocID { get; set; }
        public string PagePhotoCaption { get; set; }
        public System.DateTime PageDateAdd { get; set; }
        public Nullable<int> PageLayoutCols { get; set; }
        public int FKLayoutID { get; set; }
        public int FKMenuID { get; set; }
        public string PageMainTitleAr { get; set; }
        public string PageMainPrgrphAr { get; set; }
        public string PageBrowserTitleAr { get; set; }
    }
}