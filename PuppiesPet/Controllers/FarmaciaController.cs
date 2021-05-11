using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PuppiesPet.Models;

namespace PuppiesPet.Controllers
{
    public class FarmaciaController : Controller
    {
        private readonly ILogger<FarmaciaController> _logger;

        public FarmaciaController(ILogger<FarmaciaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }



    }
}
