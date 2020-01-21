using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServerApp.Models;

namespace ServerApp.Controllers
{
    public class HomeController : Controller
    {
        // 04
        //private readonly ILogger<HomeController> _logger;
        private DataContext context;

        // 04
        //public HomeController(ILogger<HomeController> logger)
        public HomeController(DataContext ctx)
        {
            // 04
            //_logger = logger;
            context = ctx;
        }

        public IActionResult Index()
        {
            //return View();
            //return View("Placeholder");
            //return View();
            return View(context.Products.First()); // 04
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
