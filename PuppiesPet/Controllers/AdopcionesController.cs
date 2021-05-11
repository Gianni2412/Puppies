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
    public class AdopcionesController : Controller
    {
        private readonly ILogger<AdopcionesController> _logger;

        public AdopcionesController(ILogger<AdopcionesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


       

    }
}
