using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoomRentalManager.Models;

namespace RRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentsController : ControllerBase
    {
        private readonly RRM_DBContext _context;

        public ApartmentsController(RRM_DBContext context)
        {
            _context = context;
        }

        // GET: api/Apartments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Apartment>>> GetApartment()
        {
            return await _context.Apartment.ToListAsync();
        }

        // GET: api/Apartments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Apartment>> GetApartment(int id)
        {
            var apartment = await _context.Apartment.FindAsync(id);

            if (apartment == null)
            {
                return NotFound();
            }

            return apartment;
        }

        // PUT: api/Apartments/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApartment(int id, Apartment apartment)
        {
            if (id != apartment.Id)
            {
                return BadRequest();
            }

            _context.Entry(apartment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApartmentExists(id))
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

        // POST: api/Apartments
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Apartment>> PostApartment(Apartment apartment)
        {
            _context.Apartment.Add(apartment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApartment", new { id = apartment.Id }, apartment);
        }

        // DELETE: api/Apartments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Apartment>> DeleteApartment(int id)
        {
            var apartment = await _context.Apartment.FindAsync(id);
            if (apartment == null)
            {
                return NotFound();
            }

            _context.Apartment.Remove(apartment);
            await _context.SaveChangesAsync();

            return apartment;
        }

        private bool ApartmentExists(int id)
        {
            return _context.Apartment.Any(e => e.Id == id);
        }
    }
}
