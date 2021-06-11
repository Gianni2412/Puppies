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
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace PuppiesPet.Controllers
{
    public class ServiciosController : Controller
    {
        private readonly ILogger<ServiciosController> _logger;

        private readonly ApplicationDbContext _context;

        private readonly UserManager<IdentityUser> _userManager;

        public ServiciosController(ILogger<ServiciosController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager
            )
        {
            _logger = logger;
            _context = context;
              _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

      public IActionResult Listar()
        {
            var citas = _context.Reservas.OrderBy(x => x.Fecha).ToList();
            return View(citas);
        }


 //PARA MODIFICAR LA INFORMACION DE UNA CITA

    public IActionResult ModificarCita(int id)
        {
            var cita = _context.Reservas.Find(id);
            return View(cita);
        }

        [HttpPost]
        public ActionResult ModificarCita(ReservaCita r)
        {
            if (ModelState.IsValid)
            {
                var cita = _context.Reservas.Find(r.Id);
            cita.Nombre = r.Nombre;
                cita.Fecha = r.Fecha;
                cita.Hora = r.Hora;
                cita.ViewBag.Services = r.ViewBag.Services ;
                cita.ViewBag.Doctores = r.ViewBag.Doctores;
                _context.SaveChanges();
                return RedirectToAction("ModificarCita");
            }
            return View(r);
        }

        public ActionResult ModificarCita()
        {
            return View();
        }


//PARA BORRAR UNA CITA AGENDADAS

  [HttpPost]
        public IActionResult BorrarCita(int id)
        {
            var cita = _context.Reservas.Find(id);
            _context.Remove(cita);
            _context.SaveChanges();
            return RedirectToAction("Listar");

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
                return RedirectToAction("Servicios");
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



        //PARA GUARDAR UNA CITA EN CONJUNTO CON LA SELECCION DE UN SERVICIO y DOCTOR
        public ActionResult Reservar()
        {
            ViewBag.Services = _context.Servicios.ToList().Select(se => new SelectListItem(se.Nombres, se.Id.ToString()));
            ViewBag.Medicos = _context.Doctores.ToList().Select(me => new SelectListItem(me.Nombre, me.Id.ToString()));

            return View();


        }

        [HttpPost]
        public IActionResult Reservar(ReservaCita r)
        {

            if (ModelState.IsValid)
            {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("NuevaReservaConfirmacion");
            }
            return View();

        }

        public IActionResult NuevaReservaConfirmacion()
        {
            return View();
        }

        

      


        //PARA LISTAR, AGREGAR ,ELIMINAR DOCTORES

        public ActionResult Medico()
        {

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
                return RedirectToAction("Medicos");
            }
            return View(d);
        }



        [HttpPost]
        public IActionResult BorrarDoctor(int id)
        {
            var doctor = _context.Doctores.Find(id);
            _context.Remove(doctor);
            _context.SaveChanges();
            return RedirectToAction("Medicos");

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
