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
    
    public partial class tblTxCd
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTxCd()
        {
            this.tblCstmrs = new HashSet<tblCstmr>();
            this.tblDlrs = new HashSet<tblDlr>();
            this.tblDrvrs = new HashSet<tblDrvr>();
            this.tblOrdrs = new HashSet<tblOrdr>();
        }
    
        public int TxCdID { get; set; }
        public string St { get; set; }
        public string Cty { get; set; }
        public string CtyCd { get; set; }
        public Nullable<decimal> CtyTxRt { get; set; }
        public string ZpCd { get; set; }
        public string Cnty { get; set; }
        public string CntyCd { get; set; }
        public Nullable<decimal> CntyTxRt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCstmr> tblCstmrs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDlr> tblDlrs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDrvr> tblDrvrs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrdr> tblOrdrs { get; set; }
    }
}