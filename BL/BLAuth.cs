using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DomainModel;

namespace BL
{
	public static class BLAuth
	{
		public static Logon Authenticate(string email, string password, ref List<string> errors)
		{
			if (email == null)
			{
				errors.Add("Email cannot be null");
			}

			if (password == null)
			{
				errors.Add("Password cannot be null");
			}

			if (errors.Count > 0)
			{
				AsynchLog.LogNow(errors);
				return null;
			}

			return DALAuth.Authenticate(email, password, ref errors);
		}

	}
}
