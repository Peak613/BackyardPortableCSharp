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
    
    public partial class tblStyl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblStyl()
        {
            this.tblStylSzs = new HashSet<tblStylSz>();
        }
    
        public int StylID { get; set; }
        public string Styl { get; set; }
        public string StylDsc { get; set; }
        public Nullable<int> StylTypIDfk { get; set; }
        public Nullable<bool> Actv { get; set; }
        public string Nts { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblStylSz> tblStylSzs { get; set; }
        public virtual tblStylTyp_admn tblStylTyp_admn { get; set; }
    }
}
