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
    
    public partial class AboutPhoto
    {
        public int Id { get; set; }
        public string AboutText { get; set; }
        public string Photo { get; set; }
        public string DoctorName { get; set; }
        public string DoctorThink { get; set; }
        public int DepartmentId { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
