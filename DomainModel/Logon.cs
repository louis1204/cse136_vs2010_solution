using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization; // this is required

namespace DomainModel
{
  [DataContract]
  public class Logon
  {
    [DataMember]
    public string id = "";

    [DataMember]
    public string role = "";
  }
}
