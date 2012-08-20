using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWeb.Models
{

  public class PLLogon
  {
    public string ID { get; set; }
    public string Role { get; set; }
  }

  public static class LogonClientService
  {
    public static PLLogon Validate(string email, string password)
    {
      SLAuth.ISLAuth AuthClient = new SLAuth.SLAuthClient();
      string[] errors = new string[0];

      SLAuth.Logon logon = AuthClient.Authenticate(email, password, ref errors);

      PLLogon PLLogon = DTO_to_PL(logon);
      return PLLogon;
    }

    private static PLLogon DTO_to_PL(SLAuth.Logon logon)
    {
      PLLogon PLLogon = new PLLogon();
      PLLogon.ID = logon.id;
      PLLogon.Role = logon.role;

      return PLLogon;
    }

  }
}