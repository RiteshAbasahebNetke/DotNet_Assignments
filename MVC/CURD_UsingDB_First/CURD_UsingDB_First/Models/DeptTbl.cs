//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CURD_UsingDB_First.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeptTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeptTbl()
        {
            this.AreaTbls = new HashSet<AreaTbl>();
            this.EmpTbls = new HashSet<EmpTbl>();
        }
    
        public long DeptId { get; set; }
        public string DeptName { get; set; }
        public long EmpId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AreaTbl> AreaTbls { get; set; }
        public virtual EmpTbl EmpTbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpTbl> EmpTbls { get; set; }
    }
}
