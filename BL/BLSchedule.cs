using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DomainModel;

namespace BL
{
  public static class BLSchedule
  {
    public static List<Schedule> GetScheduleList(string year, string quarter, ref List<string> errors)
    {
      return (DALSchedule.GetScheduleList(year, quarter, ref errors));
    }
  }
}
