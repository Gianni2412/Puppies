using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PuppiesPet.Data;
using PuppiesPet.Models;

namespace PuppiesPet.Controllers
{
    public class MascotaController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger<MascotaController> _logger;

        public MascotaController(ILogger<MascotaController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }


        //PARA MODIFICAR LA INFORMACION DE MI MASCOTA


        public IActionResult ModificarMascota(int id)
        {
            var mascota = _context.Mascotas.Find(id);
            return View(mascota);
        }

        [HttpPost]
        public ActionResult ModificarMascota(Mascota ma)
        {
            if (ModelState.IsValid)
            {
                var mascota = _context.Mascotas.Find(ma.Id);
                mascota.Nombre = ma.Nombre;
                mascota.Edad = ma.Edad;
                mascota.Peso = ma.Peso;
                mascota.Enfermedades = ma.Enfermedades;
                _context.SaveChanges();
                return RedirectToAction("ModificarMascotaConfirmado");
            }
            return View(ma);
        }

        public ActionResult ModificarMascotaConfirmado()
        {
            return View();
        }




        // PARA CREAR UNA NUEVA MASCOTA :D
        public IActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(Mascota ma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ma);
                _context.SaveChanges();
                return RedirectToAction("Lista");
            }
            return View(ma);
        }

        public IActionResult Lista()
        {
            var mascotas = _context.Mascotas.OrderBy(x => x.Nombre).ToList();
            return View(mascotas);
        }


        //PARA BORRAR UNA MASCOTA :( 
        [HttpPost]
        public IActionResult BorrarMascota(int id)
        {
            var mascota = _context.Mascotas.Find(id);
            _context.Remove(mascota);
            _context.SaveChanges();
            return RedirectToAction("Lista");

        }

    }


}
