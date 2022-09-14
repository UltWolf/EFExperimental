using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFExperimental.Context;
using EFExperimental.TestData;

namespace EFExperimental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestParentsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TestParentsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/TestParents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestParent>>> GetTestParent()
        {
          if (_context.TestParent == null)
          {
              return NotFound();
          }
            return await _context.TestParent.ToListAsync();
        }

        // GET: api/TestParents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TestParent>> GetTestParent(long id)
        {
          if (_context.TestParent == null)
          {
              return NotFound();
          }
            var testParent = await _context.TestParent.FindAsync(id);

            if (testParent == null)
            {
                return NotFound();
            }

            return testParent;
        }

        // PUT: api/TestParents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestParent(long id, TestParent testParent)
        {
            if (id != testParent.Id)
            {
                return BadRequest();
            }

            _context.Entry(testParent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestParentExists(id))
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

        // POST: api/TestParents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TestParent>> PostTestParent(TestParent testParent)
        {
          if (_context.TestParent == null)
          {
              return Problem("Entity set 'ApplicationContext.TestParent'  is null.");
          }
            _context.TestParent.Add(testParent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTestParent", new { id = testParent.Id }, testParent);
        }

        // DELETE: api/TestParents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestParent(long id)
        {
            if (_context.TestParent == null)
            {
                return NotFound();
            }
            var testParent = await _context.TestParent.FindAsync(id);
            if (testParent == null)
            {
                return NotFound();
            }

            _context.TestParent.Remove(testParent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TestParentExists(long id)
        {
            return (_context.TestParent?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
