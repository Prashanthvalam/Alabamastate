using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AlabamaMVCweb.Models;
using Alabama.BLL.Interface;

namespace AlabamaMVCweb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IEmployeeFiling _employeeFiling;
        private readonly ICliamantInterface _icliamantInterface;
        public HomeController(ILogger<HomeController> logger, IEmployeeFiling employeeFiling, ICliamantInterface cliamantInterface)
        {
            _logger = logger;
            _employeeFiling = employeeFiling;
            _icliamantInterface = cliamantInterface;
        }

        public IActionResult Index()
        {
            var result = _employeeFiling.create();
            ViewBag.number = result;
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
