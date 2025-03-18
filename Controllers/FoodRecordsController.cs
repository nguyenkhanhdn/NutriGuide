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
    public class FoodRecordsController : Controller
    {
        private readonly NutriGuideDbContext _context;

        public FoodRecordsController(NutriGuideDbContext context)
        {
            _context = context;
        }

        // GET: FoodRecords
        public async Task<IActionResult> Index()
        {
            var nutriGuideDbContext = _context.FoodRecords.Include(f => f.User);
            return View(await nutriGuideDbContext.ToListAsync());
        }

        // GET: FoodRecords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodRecord = await _context.FoodRecords
                .Include(f => f.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (foodRecord == null)
            {
                return NotFound();
            }

            return View(foodRecord);
        }

        // GET: FoodRecords/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "FullName");
            return View();
        }

        // POST: FoodRecords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,FoodName,GlycemicIndex,DateConsumed")] FoodRecord foodRecord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(foodRecord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "FullName", foodRecord.UserId);
            return View(foodRecord);
        }

        // GET: FoodRecords/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodRecord = await _context.FoodRecords.FindAsync(id);
            if (foodRecord == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "FullName", foodRecord.UserId);
            return View(foodRecord);
        }

        // POST: FoodRecords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,FoodName,GlycemicIndex,DateConsumed")] FoodRecord foodRecord)
        {
            if (id != foodRecord.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(foodRecord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FoodRecordExists(foodRecord.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "FullName", foodRecord.UserId);
            return View(foodRecord);
        }

        // GET: FoodRecords/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodRecord = await _context.FoodRecords
                .Include(f => f.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (foodRecord == null)
            {
                return NotFound();
            }

            return View(foodRecord);
        }

        // POST: FoodRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var foodRecord = await _context.FoodRecords.FindAsync(id);
            if (foodRecord != null)
            {
                _context.FoodRecords.Remove(foodRecord);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FoodRecordExists(int id)
        {
            return _context.FoodRecords.Any(e => e.Id == id);
        }
    }
}
