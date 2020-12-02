using Cinema.Data;
using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
namespace Cinema.Controllers
{
	public class HomeController : Controller
	{
		private CinemaContext db = new CinemaContext();

		public ActionResult Index()
		{
			bool IsAdminExist = db.AdminUser.Any();
			if (!IsAdminExist)
			{
				AdminUser user = new AdminUser();

				user.UserName = "Parniyan";
				user.Password = "123";
				db.AdminUser.Add(user);
				db.SaveChanges();
			}
			var tickets = db.Tickets.Include(t => t.Cinema).Include(t => t.City).Include(t => t.Movie);
			return View(tickets);
		}
	}
}