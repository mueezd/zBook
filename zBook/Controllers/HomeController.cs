using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using zBook.Models;

namespace zBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddCustomer()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(SignUpModel signup)
        {
            CustomerInfo customer = new CustomerInfo();
            customer.firstName = signup.firstName;
            customer.lastName = signup.lastName;
            customer.CompanyName = signup.CompanyName;
            customer.emailId = signup.emailId;
            customer.phoneNo = signup.phoneNo;
            _context.Custmers.Add(customer);
            _context.SaveChanges();

            return View();

        }
        public IActionResult GetAllCustomer()
        {
            var customerlist = _context.Custmers.ToList();
            return View(customerlist);
        }
        [HttpPost]
        public IActionResult AddCustomer(AddCustomer AddCust)
        {


            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
