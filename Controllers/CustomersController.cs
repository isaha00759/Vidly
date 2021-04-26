using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private DBContext _context { get; set; }

        public CustomersController()
        {
            this._context = new DBContext();
        }

        protected override void Dispose(bool disposing)
        {
            this._context.Dispose();
        }
        
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(e => e.MembershipType).ToList();

            return View(customers);
        }

        [Route]
        public ActionResult Details(int id)
        {
            var customer = this._context.Customers.Include(e => e.MembershipType).SingleOrDefault(e => e.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}