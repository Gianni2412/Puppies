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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Trabaja()
        {
            return View();
        }
        public IActionResult Adopciones()
        {
            return View();
        }

        public IActionResult Nosotros()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }






        [HttpGet]
        public IActionResult CrearContacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearContacto(Contactar objContactar)
        {
            _context.Add(objContactar);
            _context.SaveChanges();
            ViewData["Message"] = "su consulta ya esta registrada";
            return View();

        }

           [HttpGet]
        public IActionResult CrearTrabajo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearTrabajo(TrabajaNosotros objTrabajo)
        {
            _context.Add(objTrabajo);
            _context.SaveChanges();
            ViewData["Message"] = "Su Cv ha sido guardado";
            return View();

        }
    }
}
