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

namespace PuppiesPet.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;

        private readonly ApplicationDbContext _context;



        public UsuarioController(ILogger<UsuarioController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Listar()
        {

            var usuarios = _context.Usuarios.OrderBy(u => u.Nombres).ToList();
            return View(usuarios);

        }

        public IActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registrar(Usuario u)
        {

            if (ModelState.IsValid)
            {
                _context.Add(u);
                _context.SaveChanges();
                return RedirectToAction("InformacionConfirmacion");
            }
            return View();

        }

        public IActionResult InformacionConfirmacion()
        {
            return View();
        }


    }
}
