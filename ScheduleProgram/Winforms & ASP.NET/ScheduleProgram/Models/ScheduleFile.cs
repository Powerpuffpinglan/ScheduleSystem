//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScheduleProgram.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ScheduleFile
    {
        public string Week { get; set; }
        public string Day { get; set; }
        public System.TimeSpan Time { get; set; }
        public int ScheduleCode { get; set; }
        public int Id { get; set; }
    
        public virtual ScheduleTable ScheduleTable { get; set; }
    }
}