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
    public class UsuarioController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public UsuarioController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }


        public IActionResult Registro()
        {
            return View();
        }

    }
}
