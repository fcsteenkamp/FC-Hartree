using Hartree.Interfaces;
using Hartree.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hartree.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHoldings _holdingsService;
        public HomeController(ILogger<HomeController> logger, IHoldings holdingsService)
        {
            _logger = logger;
            _holdingsService = holdingsService;
        }

        public IActionResult Index()
        {
            return View(_holdingsService.GetHolding(1));
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
