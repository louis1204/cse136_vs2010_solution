using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC3.Models; // this is required...

namespace MVC3.Controllers
{
	public class LoginController : Controller
	{
		//
		// GET: /Login/
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Index(FormCollection collection)
		{
			try
			{
				string email = collection["Email"];
				string password = collection["Password"];
				// PLLogon logon = LogonClientService.Validate(email, password);
				PLLogon logon = LogonClientService.Validate(email, password);

				if (logon.Role.Equals("invalid"))
				{
					// ViewBag is a way to pass info from controller to the view page.
					ViewBag.message = "Invalid login";
				}
				else
				{
					Session["role"] = logon.Role;
					Session["id"] = logon.ID;
					Session["email"] = email;

					if (Session["role"].Equals("admin"))
					{
						return RedirectToAction("Index", "Student");
					}
					else if (Session["role"].Equals("student"))
					{
						return RedirectToAction("Index", "Schedule");
					}
				}
			}
			catch
			{
				return View("Index");
			}
			return View("Index");
		}

		[HttpPost]
		public ActionResult LogOff()
		{
			Session["role"] = null;
			Session["id"] = null;
			Session["email"] = null;
			return RedirectToAction("Index", "Home");
		}
	}
}
