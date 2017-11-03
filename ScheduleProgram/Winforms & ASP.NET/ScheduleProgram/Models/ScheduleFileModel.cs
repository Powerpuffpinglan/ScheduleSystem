using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScheduleProgram.Models
{
    public class ScheduleFileModel
    {
        public string Week { get; set; }
        public string Day { get; set; }
        public TimeSpan Time { get; set; }
        public int ScheduleCode { get; set; }
        public int Id { get; set; }
    }
}