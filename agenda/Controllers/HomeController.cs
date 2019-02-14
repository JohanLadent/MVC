using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using agenda.Models;

namespace agenda.Controllers
{
    public class HomeController : Controller
    {
        private agendaContext db = new agendaContext();
        // GET: Home
        public ActionResult Index()
        {
            ViewData["date"] = DateTime.Now;
            // (db.Brokers.ToList())
            return View();
        }
        public ActionResult AddBroker()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddBroker([Bind(Include = "LastName, FirstName, Mail, PhoneNumber")] Broker broker)
        {
            if (ModelState.IsValid)
            {
                db.Brokers.Add(broker);
                db.SaveChanges();
                return RedirectToAction("ListBroker");
            }

            return View();
        }
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCustomer([Bind(Include = "LastName, FirstName, Mail, PhoneNumber, Budget, Subject")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("ListCustomer");
            }

            return View();
        }
        public ActionResult AddAppointment()
        {
            return View();
        }
        public ActionResult ProfilBroker()
        {
            return View();
        }
        public ActionResult ProfilCustomer()
        {
            return View();
        }
            public ActionResult ListBroker()
        {
            List<Broker> Brokers = db.Brokers.ToList();
            return View(Brokers);
        }
        public ActionResult ListCustomer()
        {
            List<Customer> Customers = db.Customers.ToList();
            return View(Customers);
        }
    }
}