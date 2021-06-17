using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PuppiesPet.Data;
using PuppiesPet.Models;

namespace PuppiesPet.Controllers
{
    public class ProformaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProformaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Proforma
        public async Task<IActionResult> Index()
        {
            return View(await _context.Proformas.ToListAsync());
        }

        // GET: Proforma/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proforma = await _context.Proformas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (proforma == null)
            {
                return NotFound();
            }

            return View(proforma);
        }

        // GET: Proforma/Create
        public IActionResult Create()
        {
            return View();
        }
         public IActionResult Compra()
        {
            var proforma=_context.Proformas.ToList();
            return View(proforma);
        }

        // POST: Proforma/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserID,Quantity,Price")] Proforma proforma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proforma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(proforma);
        }

        // GET: Proforma/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proforma = await _context.Proformas.FindAsync(id);
            if (proforma == null)
            {
                return NotFound();
            }
            return View(proforma);
        }

        // POST: Proforma/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UserID,Quantity,Price")] Proforma proforma)
        {
            if (id != proforma.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proforma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProformaExists(proforma.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(proforma);
        }

        // GET: Proforma/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proforma = await _context.Proformas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (proforma == null)
            {
                return NotFound();
            }

            return View(proforma);
        }

        // POST: Proforma/Delete/5
        [HttpPost, ActionName("Borrar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proforma = await _context.Proformas.FindAsync(id);
            _context.Proformas.Remove(proforma);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProformaExists(int id)
        {
            return _context.Proformas.Any(e => e.ID == id);
        }
        
    }
}
