//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFirstEx12.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CatTbl
    {
        public CatTbl()
        {
            this.ProdTbls = new HashSet<ProdTbl>();
        }
    
        public long CategoryID { get; set; }
        public string CategoryName { get; set; }
    
        public virtual ICollection<ProdTbl> ProdTbls { get; set; }
    }
}