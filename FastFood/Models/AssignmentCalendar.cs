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
    
    public partial class AssignmentCalendar
    {
        public int StaffID { get; set; }
        public int ShiftID { get; set; }
        public int CalendarID { get; set; }
        public string Note { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Calendar Calendar { get; set; }
        public virtual Shift Shift { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
