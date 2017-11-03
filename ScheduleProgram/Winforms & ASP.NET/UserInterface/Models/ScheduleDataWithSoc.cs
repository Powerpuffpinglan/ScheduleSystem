using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserInterface.Models
{
    public class ScheduleDataWithSoc
    {
        public int id { get; set; }
        public string week { get; set; }
        public string day { get; set; }
        public TimeSpan time { get; set; }
        public int ScheduleCode { get; set; }
        public string soc { get; set; }
    }
}