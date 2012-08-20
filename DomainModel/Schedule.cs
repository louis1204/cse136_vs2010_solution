using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization; // this is required

namespace DomainModel
{
  [DataContract]
  public class Schedule
  {
    [DataMember]
    public int id = 0;

    [DataMember]
    public string year = "";
    
    [DataMember]
    public string quarter = "";
    
    [DataMember]
    public string session = "";
    
    [DataMember]
    public Course course;
    
  }
}
