using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class ScheduleFileModel
    {
        
        public string Week { get; set; }
        public string Day { get; set; }
        public TimeSpan Time { get; set; }
        public int ScheduleCode { get; set; }

        //All the values are split on ";"
        public static ScheduleFileModel FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(';');
            var schedulingValues = new ScheduleFileModel();
            schedulingValues.Week = values[0];
            schedulingValues.Day = values[1];
            schedulingValues.Time = TimeSpan.Parse(values[2]);
            schedulingValues.ScheduleCode = Convert.ToInt32(values[3]);
            return schedulingValues;
        }
    }
}
