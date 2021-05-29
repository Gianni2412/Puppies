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
    public class ServiciosController : Controller
    {
        private readonly ILogger<ServiciosController> _logger;

        private readonly ApplicationDbContext _context;

        public ServiciosController(ILogger<ServiciosController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Reservar()
        {
            return View();
        }


        //CRUD PARA AÑADIR SERVICIOS (ADMIN)

        public IActionResult Services()
        {
            var servicios = _context.Servicios.OrderBy(s => s.Nombres).ToList();
            return View(servicios);
        }

        public IActionResult NuevoServicio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NuevoServicio(Servicio s)
        {
            if (ModelState.IsValid)
            {
                _context.Add(s);
                _context.SaveChanges();
                return RedirectToAction("Services");
            }
            return View(s);
        }



        [HttpPost]
        public IActionResult BorrarServicios(int id)
        {
            var servicio = _context.Servicios.Find(id);
            _context.Remove(servicio);
            _context.SaveChanges();
            return RedirectToAction("Services");

        }


    }
}
