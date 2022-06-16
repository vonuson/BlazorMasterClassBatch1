using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementPortal.Server;
using EmployeeManagementPortal.Shared.Models;

namespace EmployeeManagementPortal.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SamplesController : ControllerBase
    {
        private readonly SampleContext _context;

        public SamplesController(SampleContext context)
        {
            _context = context;
        }

        // GET: api/Samples
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sample>>> GetSamples()
        {
          if (_context.Samples == null)
          {
              return NotFound();
          }
            return await _context.Samples.ToListAsync();
        }

        // GET: api/Samples/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sample>> GetSample(int id)
        {
          if (_context.Samples == null)
          {
              return NotFound();
          }
            var sample = await _context.Samples.FindAsync(id);

            if (sample == null)
            {
                return NotFound();
            }

            return sample;
        }

        // PUT: api/Samples/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSample(int id, Sample sample)
        {
            if (id != sample.Id)
            {
                return BadRequest();
            }

            _context.Entry(sample).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SampleExists(id))
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

        // POST: api/Samples
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sample>> PostSample(Sample sample)
        {
          if (_context.Samples == null)
          {
              return Problem("Entity set 'SampleContext.Samples'  is null.");
          }
            _context.Samples.Add(sample);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSamples), new { id = sample.Id }, sample);
        }

        // DELETE: api/Samples/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSample(int id)
        {
            if (_context.Samples == null)
            {
                return NotFound();
            }
            var sample = await _context.Samples.FindAsync(id);
            if (sample == null)
            {
                return NotFound();
            }

            _context.Samples.Remove(sample);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SampleExists(int id)
        {
            return (_context.Samples?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
