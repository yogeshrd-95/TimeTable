using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeTable.Models;

namespace TimeTable.Controllers
{
    public class GenerateTimeTableController : Controller
    {
        // GET: GenerateTimeTable
        
        public ActionResult Index(int ? intTotalSubjects, int ? intTotalHoursForWeek)
        {
            ViewBag.TotalSubjects = intTotalSubjects;

            ViewBag.TotalHoursForWeek = intTotalHoursForWeek;
            return View();
        }
    }
}