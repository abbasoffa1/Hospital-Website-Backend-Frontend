//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DayTime
    {
        public int Id { get; set; }
        public int DayId { get; set; }
        public int TimetableId { get; set; }
    
        public virtual Day Day { get; set; }
        public virtual Timetable Timetable { get; set; }
    }
}
