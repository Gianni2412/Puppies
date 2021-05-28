using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PuppiesPet.Models;
using PuppiesPet.Data;

namespace PuppiesPet.Controllers
{
    public class MascotaController : Controller
    {
        private readonly ILogger<MascotaController> _logger;

        private readonly ApplicationDbContext _context;

        public MascotaController(ILogger<MascotaController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Editar(){

            return View();
        }

        public IActionResult Listar(){
            return View();
        }
    }
}
