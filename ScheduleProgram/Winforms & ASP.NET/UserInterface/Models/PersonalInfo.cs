//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserInterface.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonalInfo
    {
        public int Id { get; set; }
        public string PersonellNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> ScheduleCode { get; set; }
    
        public virtual ScheduleTable ScheduleTable { get; set; }
    }
}
