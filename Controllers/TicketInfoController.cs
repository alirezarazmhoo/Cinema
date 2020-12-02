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
    public class TicketInfoController : Controller
    {
        private CinemaContext db = new CinemaContext();

        // GET: TicketInfo
        public ActionResult Index(int ?id)
        {
            var ticket = db.Tickets.Include(t => t.Cinema).Include(t => t.City).Include(t => t.Movie).Where(s => s.Id == id).FirstOrDefault() ;
            return View(ticket);
        }

        [Authorize]
        public ActionResult SaveRequest(int? id)
        {
            var _UserName = Session["CustomerName"];
            Customer customer = db.Customers.Where(s => s.UserName == _UserName.ToString()).FirstOrDefault();
            Requests requests = new Requests();
            requests.TicketId = id.Value;
            requests.CustomerId = customer.Id;
            requests.Date = DateTime.Now;
            db.Requests.Add(requests);
            db.SaveChanges();

            return RedirectToAction(nameof(Success));

        }
        public ActionResult Success()
        {
            return View();
        }
    }
}