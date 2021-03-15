using Common.Interfaces;
using Crawford.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Crawford.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;
        private readonly IDataLossService _dataLossService;

        public HomeController(ILogger<HomeController> logger, IUserService userService, IDataLossService dataLossService)
        {
            _logger = logger;
            _userService = userService;
            _dataLossService = dataLossService;
        }

        public IActionResult Index()
        {
            var data = _dataLossService.GetLossTypes();
            return View(data);
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
