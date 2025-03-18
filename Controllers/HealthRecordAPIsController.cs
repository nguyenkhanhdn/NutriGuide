using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NutriGuide.Models;
using Tensorflow.Contexts;

namespace NutriGuide.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthRecordAPIsController : ControllerBase
    {
        private readonly NutriGuideDbContext _context;

        public HealthRecordAPIsController(NutriGuideDbContext context)
        {
            _context = context;
        }

        // GET: api/HealthRecordAPIs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HealthRecord>>> GetHealthRecords()
        {
            return await _context.HealthRecords.ToListAsync();
        }

        // GET: api/HealthRecordAPIs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HealthRecord>> GetHealthRecord(int id)
        {
            var healthRecords = _context.HealthRecords
            .Where(h => h.UserId == id)
            .OrderBy(h => h.DateRecorded)
            .Select(h => new
            {
                Date = h.DateRecorded.ToString("yyyy-MM-dd"),
                BloodSugar = h.BloodSugar,
                SystolicBP = h.SystolicPressure,
                DiastolicBP = h.DiastolicPressure
            })
            .ToList();

            return Ok(healthRecords);
        }

        // PUT: api/HealthRecordAPIs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHealthRecord(int id, HealthRecord healthRecord)
        {
            if (id != healthRecord.Id)
            {
                return BadRequest();
            }

            _context.Entry(healthRecord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HealthRecordExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/HealthRecordAPIs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HealthRecord>> PostHealthRecord(HealthRecord healthRecord)
        {
            _context.HealthRecords.Add(healthRecord);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHealthRecord", new { id = healthRecord.Id }, healthRecord);
        }

        // DELETE: api/HealthRecordAPIs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHealthRecord(int id)
        {
            var healthRecord = await _context.HealthRecords.FindAsync(id);
            if (healthRecord == null)
            {
                return NotFound();
            }

            _context.HealthRecords.Remove(healthRecord);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HealthRecordExists(int id)
        {
            return _context.HealthRecords.Any(e => e.Id == id);
        }
    }
}
