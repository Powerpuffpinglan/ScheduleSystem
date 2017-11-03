using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserInterface.Models;

namespace UserInterface.Controllers
{
    public class HomeController : Controller
    {
        
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        PowiEntities3 db = new PowiEntities3();
        public ActionResult Index()
        {  
            return View();
        }


        [HttpPost]
        public ActionResult Report(string search)
        {

            //Söker efter person i datbasen
            var context = new PowiEntities3();
            var ems = context.PersonalInfo.Where(e => e.PersonellNumber == search).FirstOrDefault();
            if (ems != null)
            {
                return View(ems);
            }
            else
            {
                return View("Error");
            }

        }
        public ActionResult Schedule(string search)
        {
            var context = new PowiEntities3();
            var ems = context.PersonalInfo.Where(e => e.PersonellNumber == search).FirstOrDefault();
            //Hämtar schemat ifrån Serverna
            string convertSocToString = Convert.ToString(ems);

            var scheduleCode = (from persons in db.PersonalInfo
                                where persons.PersonellNumber == convertSocToString
                                select persons.ScheduleCode).FirstOrDefault();
            //Get the list from service and shows in the view
            List<ScheduleDataWithSoc> listToView = new List<ScheduleDataWithSoc>();
            List<ServiceReference1.ScheduleFileCon> listFromService = client.GetSchedule(scheduleCode).ToList();

            foreach (var post in listFromService)
            {
                ScheduleDataWithSoc listObject = new ScheduleDataWithSoc
                {
                    id = post.idValue,
                    week = post.weekValue,
                    day = post.dayValue,
                    time = post.timeValue,
                    ScheduleCode = post.scheduleCodeValue,
                    soc = convertSocToString
                };
                listToView.Add(listObject);
                
            }
            return View(listToView);
        }


    }
}