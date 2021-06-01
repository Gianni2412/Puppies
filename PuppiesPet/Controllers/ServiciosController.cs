using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PuppiesPet.Models;
using PuppiesPet.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

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


       


        //CRUD PARA AÑADIR SERVICIOS (ADMIN)

        public IActionResult Servicios()
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
            return RedirectToAction("Servicios");

        }


        public IActionResult EditarServicios(int id)
        {
            var servicios = _context.Servicios.Find(id);
            return View(servicios);
        }

        [HttpPost]
        public ActionResult EditarServicios(Servicio se)
        {
            if (ModelState.IsValid)
            {
                var servicios = _context.Servicios.Find(se.Id);
                servicios.Nombres = se.Nombres;
                _context.SaveChanges();
                return RedirectToAction("editarServiciosconfirmado");
            }
            return View(se);
        }

        public ActionResult editarServiciosconfirmado()
        {
            return View();
        }



        //PARA GUARDAR UNA CITA EN CONJUNTO CON LA SELECCION DE UN SERVICIO
        public ActionResult Reservar()
        {
            ViewBag.Services = _context.Servicios.ToList().Select(se => new SelectListItem(se.Nombres, se.Id.ToString()));
            return View();
        }




        //PARA LISTAR, AGREGAR ,ELIMINAR DOCTORES

        public ActionResult Medico()
        {
            ViewBag.Medicos = _context.Doctores.ToList().Select(d => new SelectListItem(d.Nombre, d.Id.ToString()));
            return View();
        }

        public IActionResult Medicos()
        {
            var medicos = _context.Doctores.OrderBy(d => d.Nombre).ToList();
            return View(medicos);
        }

        public IActionResult NuevoMedico()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NuevoMedico(Doctor d)
        {
            if (ModelState.IsValid)
            {
                _context.Add(d);
                _context.SaveChanges();
                return RedirectToAction("Doctor");
            }
            return View(d);
        }



        [HttpPost]
        public IActionResult BorrarDoctor(int id)
        {
            var doctor = _context.Doctores.Find(id);
            _context.Remove(doctor);
            _context.SaveChanges();
            return RedirectToAction("Doctor");

        }


        public IActionResult EditarDoctor(int id)
        {
            var doctor = _context.Doctores.Find(id);
            return View(doctor);
        }

        [HttpPost]
        public ActionResult EditarDoctor(Doctor d)
        {
            if (ModelState.IsValid)
            {
                var doctor = _context.Doctores.Find(d.Id);
                doctor.Nombre = d.Nombre;
                _context.SaveChanges();
                return RedirectToAction("editadoctorConfirmado");
            }
            return View(d);
        }

        public ActionResult editardoctorconfirmado()
        {
            return View();
        }




    }
}
