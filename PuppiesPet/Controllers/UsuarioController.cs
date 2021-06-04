using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PuppiesPet.Models;
using Microsoft.EntityFrameworkCore;

namespace PuppiesPet.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly ApplicationDbContext _context;

        public UsuarioController(ILogger<UsuarioController> logger,
        ApplicationDbContext context)
        {
            _logger = logger;
             _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }


        public IActionResult RegistrarUsuario()
        {
            return View();
        }
        public IActionResult index()
        {
            var listUsuarios=_context.Usuario.ToList();
            return View(listUsuarios);

       //* public async Task<IActionResult> ListarRegistroUsuario()
      //  {
       //     return View(await _context.Usuario.ToListAsync());*//
        }
    }
}
