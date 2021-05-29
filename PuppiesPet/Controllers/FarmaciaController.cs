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
    public class FarmaciaController : Controller
    {


        private readonly ApplicationDbContext _context;

        public FarmaciaController(ApplicationDbContext context)
        {

            _context = context;
        }

        public IActionResult Listar()
        {
            return View();
        }


    }

}