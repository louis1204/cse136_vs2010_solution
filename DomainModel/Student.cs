using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization; // this is required

namespace DomainModel
{
  [DataContract]
  public class Student
  {
    [DataMember]
    public string id = "";

    [DataMember]
    public string ssn = "";
    
    [DataMember]
    public string first_name = "";
    
    [DataMember]
    public string last_name = "";
    
    [DataMember]
    public string email = "";

    [DataMember]
    public string password = "";

    [DataMember]
    public float shoe_size = 0;
    
    [DataMember]
    public int weight = 0;
    
    [DataMember]
    public List<Schedule> enrolled;

  }
}
