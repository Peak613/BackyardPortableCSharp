//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackyardPortableCSharp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblOptn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOptn()
        {
            this.tblBldgOptns = new HashSet<tblBldgOptn>();
        }
    
        public int OptnID { get; set; }
        public string Optn { get; set; }
        public string OptnDscrptn { get; set; }
        public Nullable<decimal> OptnPrc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBldgOptn> tblBldgOptns { get; set; }
    }
}
