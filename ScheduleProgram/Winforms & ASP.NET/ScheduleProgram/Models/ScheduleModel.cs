using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScheduleProgram.Models
{
    public class ScheduleModel
    {
        public int ScheduleCode { get; set; }
        public DateTime ValidForm { get; set; }
        public DateTime ValidTo { get; set; }
        public string Uploader { get; set; }
        public string ScheduleFileName { get; set; }
    }
}