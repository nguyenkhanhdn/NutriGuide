using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NutriGuide.Models;

namespace NutriGuide.Controllers
{
    public class BmisController : Controller
    {
        private readonly NutriGuideDbContext _context;

        public BmisController(NutriGuideDbContext context)
        {
            _context = context;
        }

        // GET: Bmis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bmis.ToListAsync());
        }

        // GET: Bmis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bmi = await _context.Bmis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bmi == null)
            {
                return NotFound();
            }

            return View(bmi);
        }

        // GET: Bmis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bmis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Age,MaleBmi,FenaleBmi")] Bmi bmi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bmi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bmi);
        }

        // GET: Bmis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bmi = await _context.Bmis.FindAsync(id);
            if (bmi == null)
            {
                return NotFound();
            }
            return View(bmi);
        }

        // POST: Bmis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Age,MaleBmi,FenaleBmi")] Bmi bmi)
        {
            if (id != bmi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bmi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BmiExists(bmi.Id))
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
            return View(bmi);
        }

        // GET: Bmis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bmi = await _context.Bmis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bmi == null)
            {
                return NotFound();
            }

            return View(bmi);
        }

        // POST: Bmis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bmi = await _context.Bmis.FindAsync(id);
            if (bmi != null)
            {
                _context.Bmis.Remove(bmi);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BmiExists(int id)
        {
            return _context.Bmis.Any(e => e.Id == id);
        }
    }
}
