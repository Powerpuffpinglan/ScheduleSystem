using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<ScheduleFileCon> GetSchedule(int? scheduleCode);

    }

    //Den brys sig inte om källan, brys sig bara om obejektet

    [DataContract]
    public class ScheduleFileCon
    {
        string week;
        string day;
        TimeSpan time;
        int scheduleCode;
        int id;


        [DataMember]
        public string weekValue
        {
            get { return week; }
            set { week = value; }
        }

        [DataMember]
        public string dayValue
        {
            get { return day; }
            set { day = value; }
        }

        [DataMember]
        public TimeSpan timeValue
        {
            get { return time; }
            set { time = value; }
        }

        [DataMember]
        public int scheduleCodeValue
        {
            get { return scheduleCode; }
            set { scheduleCode = value; }
        }

        [DataMember]
        public int idValue
        {
            get { return id; }
            set { id = value; }
        }


    }
}
