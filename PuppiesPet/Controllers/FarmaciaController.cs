using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PuppiesPet.Data;
using PuppiesPet.Models;

namespace PuppiesPet.Controllers
{
    public class FarmaciaController : Controller
    {
        private readonly ILogger<FarmaciaController> _logger;

        private readonly ApplicationDbContext _context;

        public FarmaciaController(ILogger<FarmaciaController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Catalogo()
        {
            return View();
        }


//CRUD PARA PRODUCTOS//
        public IActionResult Editar()
        {
            return View();
        }



        public IActionResult Listar()
        {
            return View();
        }



        public IActionResult Crear()
        {
            return View();
        }


//REGISTRANDO CATEGORIAS DE PRODUCTOS
        public IActionResult CategoriasFarmacia()
        {
            return View();
        }

    }
}
