using Microsoft.AspNetCore.Mvc;
using PriceQuotationApp.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace PriceQuotationApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult PriceQuotation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PriceQuotation(Price price)
        {
            if (ModelState.IsValid)
            {
                price.Calculate();

                return View(price);
            }
            else
            {
                return View(price);
            }            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
