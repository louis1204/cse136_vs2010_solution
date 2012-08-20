using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization; // this is required

namespace DomainModel
{
  [DataContract]
  public class Course
  {
    [DataMember]
    public string id = "";

    [DataMember]
    public string title = "";
    
    [DataMember]
    public string description = "";
  }
}
