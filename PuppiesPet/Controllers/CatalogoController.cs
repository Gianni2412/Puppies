using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using PuppiesPet.Data;
using PuppiesPet.Models;

namespace PuppiesPet.Controllers
{
    public class CatalogoController :  Controller
    {
        
        private readonly ILogger<CatalogoController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public CatalogoController(ILogger<CatalogoController> logger,
            ApplicationDbContext context,
            UserManager<IdentityUser> userManager)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
        }

        
        public async Task<IActionResult> Index()
        {
            var productos = from o in _context.Productos select o;
            productos = productos.Where(s => s.Status.Equals("A"));
            return View(await productos.ToListAsync());
        }

        public async Task<IActionResult> Add(int? id)
        {
            var userID = _userManager.GetUserName(User);
            if(userID == null){
                ViewData["Message"] = "Por favor debe loguearse antes de agregar un producto";
                List<Producto> productos = new List<Producto>();
                return  View("Index",productos);
            }else{
                var producto = await _context.Productos.FindAsync(id);
                Proforma proforma = new Proforma();
                proforma.Producto = producto;
                proforma.Price = producto.Precio;
                proforma.Quantity = 1;
                proforma.UserID = userID;
                _context.Add(proforma);
                await _context.SaveChangesAsync();
                return  RedirectToAction(nameof(Index));
            }

        }        
    }
}