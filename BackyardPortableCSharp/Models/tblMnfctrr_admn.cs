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
    
    public partial class tblMnfctrr_admn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMnfctrr_admn()
        {
            this.tblBldgs = new HashSet<tblBldg>();
        }
    
        public int MnfctrrID { get; set; }
        public string Mnfctrr { get; set; }
        public string MnfctrrNts { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBldg> tblBldgs { get; set; }
    }
}
