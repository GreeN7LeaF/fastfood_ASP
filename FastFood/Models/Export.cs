//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FastFood.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Export
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Export()
        {
            this.ExportDetails = new HashSet<ExportDetail>();
        }
    
        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> StaffID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExportDetail> ExportDetails { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
