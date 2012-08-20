using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DomainModel;
using BL;

namespace SL
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SLAuth" in code, svc and config file together.
  public class SLAuth : ISLAuth
  {

    public Logon Authenticate(string email, string password, ref List<string> errors)
    {
      return BLAuth.Authenticate(email, password, ref errors);
    }

  }
}
