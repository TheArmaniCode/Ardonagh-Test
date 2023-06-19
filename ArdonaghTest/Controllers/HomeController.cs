using ArdonaghTest.Interfaces;
using ArdonaghTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ArdonaghTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICustomerService _customerService;

        public HomeController(ILogger<HomeController> logger, ICustomerService customerService)
        {
            _logger = logger;
            _customerService = customerService;
        }

        public IActionResult Index(List<CustomerModel> inCustomers)
        {
            return View(inCustomers);
        }

        public IActionResult AddCustomer(List<CustomerModel> inCustomers, string inName, int inAge, string inPostcode, double inHeight)
        {
            inCustomers = _customerService.AddCustomer(inCustomers, inName, inAge, inPostcode, inHeight);

            return View("Index", inCustomers);
        }

        public IActionResult EditCustomer(List<CustomerModel> inCustomers, int inID, string inName, int inAge, string inPostcode, double inHeight)
        {
            inCustomers = _customerService.EditCustomer(inCustomers, inID, inName, inAge, inPostcode, inHeight);

            return View("Index", inCustomers);
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