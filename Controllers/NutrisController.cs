using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NutriGuide.Models;

namespace NutriGuide.Controllers
{
    public class NutrisController : Controller
    {
        private readonly NutriGuideDbContext _context;

        public NutrisController(NutriGuideDbContext context)
        {
            _context = context;
        }

        // GET: Nutris
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nutris.ToListAsync());
        }

        // GET: Nutris/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nutri = await _context.Nutris
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nutri == null)
            {
                return NotFound();
            }

            return View(nutri);
        }

        [HttpGet]
        // GET: Nutris/Create
        public IActionResult Search()
        {
            return View();
        }
        // GET: Nutris/Create
        [HttpPost]
        public IActionResult Search(string symptom)
        {
            var symptoms = symptom.Split(',');

            IQueryable<Nutri> query = _context.Nutris;

            foreach (string keyword in symptoms)
                query = query.Where(p => p.Symptom.Contains(keyword));

            return View("index",query);
        }

        // GET: Nutris/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nutris/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nutrient,Symptom,Food2Eat,Amount2Eat,Frequency")] Nutri nutri)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nutri);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nutri);
        }

        // GET: Nutris/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nutri = await _context.Nutris.FindAsync(id);
            if (nutri == null)
            {
                return NotFound();
            }
            return View(nutri);
        }

        // POST: Nutris/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nutrient,Symptom,Food2Eat,Amount2Eat,Frequency")] Nutri nutri)
        {
            if (id != nutri.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nutri);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NutriExists(nutri.Id))
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
            return View(nutri);
        }

        // GET: Nutris/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nutri = await _context.Nutris
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nutri == null)
            {
                return NotFound();
            }

            return View(nutri);
        }

        // POST: Nutris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nutri = await _context.Nutris.FindAsync(id);
            if (nutri != null)
            {
                _context.Nutris.Remove(nutri);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NutriExists(int id)
        {
            return _context.Nutris.Any(e => e.Id == id);
        }
    }
}
