﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWeb.Models; // this is required...

namespace MVCWeb.Controllers
{
    public class ScheduleController : Controller
    {
      //
      // GET: /Schedule/
      public ActionResult Index(string yearFilter, string quarterFilter)
      {
        if (yearFilter == null)
          yearFilter = "";

        if (quarterFilter == null)
          quarterFilter = "";

        string student_id = Session["id"].ToString();

        PLStudent student = StudentClientService.GetStudentDetail(student_id);
        ViewData["student"] = student;

        List<PLSchedule> scheduleList = ScheduleClientService.GetScheduleList(yearFilter, quarterFilter);

        int year = DateTime.Now.Year;
        int previousYear = year - 1;
        int nextYear = year + 1;

        // only display the current year, previous year, and next year as selections
        List<SelectListItem> YearList = new List<SelectListItem>();
        YearList.Add(new SelectListItem { Text = "All Years", Value = "" });
        YearList.Add(new SelectListItem { Text = previousYear.ToString(), Value = previousYear.ToString() });
        YearList.Add(new SelectListItem { Text = year.ToString(), Value = year.ToString() });
        YearList.Add(new SelectListItem { Text = nextYear.ToString(), Value = nextYear.ToString() });

        // these usually comes from the database... 
        List<SelectListItem> QuarterList = new List<SelectListItem>();
        QuarterList.Add(new SelectListItem { Text = "All Quarters", Value = "" });
        QuarterList.Add(new SelectListItem { Text = "Fall", Value = "Fall" });
        QuarterList.Add(new SelectListItem { Text = "Winter", Value = "Winter" });
        QuarterList.Add(new SelectListItem { Text = "Spring", Value = "Spring" });
        QuarterList.Add(new SelectListItem { Text = "Summer 1", Value = "Summer 1" });
        QuarterList.Add(new SelectListItem { Text = "Summer 2", Value = "Summer 2" });

        ViewData["YearList"] = YearList;
        ViewData["QuarterList"] = QuarterList;

        return View("Index", scheduleList);
      }

      public ActionResult Filter(string yearFilter, string quarterFilter)
      {
        if (yearFilter == null)
          yearFilter = "";

        if (quarterFilter == null)
          quarterFilter = "";

        string student_id = Session["id"].ToString();

        PLStudent student = StudentClientService.GetStudentDetail(student_id);
        ViewData["student"] = student;

        List<PLSchedule> scheduleList = ScheduleClientService.GetScheduleList(yearFilter, quarterFilter);

        return Json(scheduleList);
      }
    }
}
