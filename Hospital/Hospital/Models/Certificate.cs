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
    
    public partial class Certificate
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public Nullable<int> DoctorId { get; set; }
    
        public virtual Doctor Doctor { get; set; }
    }
}
