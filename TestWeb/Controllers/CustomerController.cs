using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWeb.ViewModels;
using TestWeb.Models;

namespace TestWeb.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListCustomers()
        {
            var list = new List<Customer>
            {
            new Customer { Name = "John Smith", Id = 1 },
            new Customer { Name = "Mary Williams", Id = 2 }
            };

            var listCustomer = new ListCustomers
            {
                listOfCustomers= list
            };

            return View(listCustomer);
        }
    }
}