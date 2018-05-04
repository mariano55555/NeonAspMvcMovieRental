using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Neon.Models;

namespace Neon.Controllers
{
    public class CustomersController : Controller
    {

        private NeonContext _context;

        public CustomersController()
        {
            _context = new NeonContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
           // var customer = GetCustomer();
            var customer = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customer);
        }

        public ActionResult Show(int id)
        {
            //var customer = GetCustomer().FirstOrDefault(c => c.Id == id);
            var customer = _context.Customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
                  return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomer()
        {
            return new List<Customer>
            {
                 new Customer { Id= 1, Name = "Customer 1" },
                 new Customer { Id= 2, Name = "Customer 2" }
            };
        }
    }

}