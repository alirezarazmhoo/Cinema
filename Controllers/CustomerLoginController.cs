using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Cinema.Data;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class CustomerLoginController : Controller
    {
        // GET: CustomerLogin
        private CinemaContext db = new CinemaContext();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RegisterCustomer()
        {

            return View();
        }
        public ActionResult SaveCustomer(string UserName,string Password,string Mobile)
        {
            Customer customer = new Customer();
            customer.Mobile = Mobile;
            customer.Password = Password;
            customer.UserName = UserName;

            db.Customers.Add(customer);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();

            return Redirect("/Home/Index");
        }
        public ActionResult Register(string UserName, string Password)
        {
            if (Password == null ||UserName == null)

            {
                ViewData["ErrorLoging"] = "رمز عبور یا نام کاربری خالی است";
                return RedirectToAction(nameof(Index));
            }
            if (!db.Customers.Any(s => s.UserName == UserName) || !db.Customers.Any(s => s.Password == Password))
            {
                TempData["ErrorLoging"] = "نام کاربری یا رمز عبور صحیح نیست";
                return RedirectToAction(nameof(Index));

            }
            if (db.Customers.Any(s => s.UserName == UserName) && db.Customers.Any(s => s.Password == Password))
            {
                FormsAuthentication.SetAuthCookie(UserName, false);

                Session["CustomerName"] = UserName;
                return Redirect("/Home/Index");

            }
            return RedirectToAction(nameof(Index));


        }
    }
}