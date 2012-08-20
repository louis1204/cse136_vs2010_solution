using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWeb.Models
{
  public class PLSchedule
  {
    [Required]
    [DisplayName("Schedule ID")]
    public int schedule_id { get; set; }

    [Required]
    [DisplayName("Year")]
    public string year { get; set; }

    [Required]
    [DisplayName("Quarter")]
    public string quarter { get; set; }

    [Required]
    [DisplayName("Session")]
    public string session { get; set; }

    [Required]
    [DisplayName("Course Title")]
    public string course_title { get; set; }

    [Required]
    [DisplayName("Description")]
    public string course_description { get; set; }


  }

  public static class ScheduleClientService
  {
    public static List<PLSchedule> GetScheduleList(string year, string quarter)
    {
      List<PLSchedule> scheduleList = new List<PLSchedule>();

      SLSchedule.ISLSchedule SLSchedule = new SLSchedule.SLScheduleClient();

      string[] errors = new string[0];
      SLSchedule.Schedule[] schedulesLoaded = SLSchedule.GetScheduleList(year, quarter, ref errors);

      foreach (SLSchedule.Schedule s in schedulesLoaded)
      {
        PLSchedule schedule = DTO_to_PL(s);
        scheduleList.Add(schedule);
      }

      return scheduleList;
    }

    private static PLSchedule DTO_to_PL(SLSchedule.Schedule s)
    {
      PLSchedule mySchedule = new PLSchedule();

      mySchedule.schedule_id = s.id;
      mySchedule.year = s.year;
      mySchedule.quarter = s.quarter;
      mySchedule.session = s.session;
      mySchedule.course_title = s.course.title;
      mySchedule.course_description = s.course.description;

      return mySchedule;
    }

  }

}