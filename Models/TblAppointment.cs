//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eMEETUP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblAppointment
    {
        public int appointmentId { get; set; }
        public string personName { get; set; }
        public string subject { get; set; }
        public decimal phone { get; set; }
        public string description { get; set; }
        public System.DateTime date { get; set; }
    }
}
