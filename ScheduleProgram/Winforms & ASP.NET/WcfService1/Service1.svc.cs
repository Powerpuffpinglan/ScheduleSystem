using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{

    public class Service1 : IService1
    {
        private PowiEntities db = new PowiEntities();
        public List<ScheduleFileCon> GetSchedule(int? scheduleCode)
        {
            List<ScheduleFileCon> scheduleList = new List<ScheduleFileCon>();
            List<ScheduleFile> listFromDb = db.ScheduleFile.ToList();
            foreach (var item in listFromDb)
            {
                ScheduleFileCon scheudleObjekt = convertScheduleFileToScheduleFileCon(item);
                scheduleList.Add(scheudleObjekt);
            }
            return scheduleList;
        }





        public ScheduleFileCon convertScheduleFileToScheduleFileCon(ScheduleFile fileToCovert)
        {
            ScheduleFileCon convertedObject = new ScheduleFileCon
            {
                weekValue = fileToCovert.Week,
                dayValue = fileToCovert.Day,
                timeValue = fileToCovert.Time,
                idValue = fileToCovert.Id,
                scheduleCodeValue = fileToCovert.ScheduleCode
            };
            return convertedObject;
        }

    }
}
