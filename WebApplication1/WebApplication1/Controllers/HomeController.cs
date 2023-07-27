using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext _context;


        public HomeController(ILogger<HomeController> logger, ApplicationContext applicationContext)
        {
            _logger = logger;
            _context = applicationContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var listpay = _context.DataInvoicesPays.ToList();
            return View(listpay);
        }
 
        [HttpPost]
        public IActionResult Result()
        {
            var result = _context.DataInvoicesPays.Where(s => s.SumScore > 0).ToList();

            return View(result);
        }
        public IActionResult Privacy()
        {
            var result = _context.DataInvoicesPays.Where(s => s.SumScore > 0).ToList();

            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}