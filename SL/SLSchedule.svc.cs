﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DomainModel;
using BL;

namespace SL
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SLSchedule" in code, svc and config file together.
  public class SLSchedule : ISLSchedule
  {
    public List<Schedule> GetScheduleList(string year, string quarter, ref List<string> errors)
    {
      return BLSchedule.GetScheduleList(year, quarter, ref errors);
    }
  }
}
