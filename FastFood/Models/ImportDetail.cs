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
    
    public partial class ImportDetail
    {
        public int ImportID { get; set; }
        public int IngreID { get; set; }
        public double Quantity { get; set; }
        public Nullable<int> Unit { get; set; }
    
        public virtual Import Import { get; set; }
        public virtual Ingredient Ingredient { get; set; }
        public virtual Unit Unit1 { get; set; }
    }
}
