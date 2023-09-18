using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommerceTestAPI.DataContext;
using ECommerceTestAPI.Model;
using AutoMapper;
using ECommerceTestAPI.ModelsDTO;

namespace ECommerceTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributesController : ControllerBase
    {
        private readonly EComDbContext _context;
        private readonly IMapper _mapper;

        public AttributesController(EComDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Attributes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Attributes>>> GetAttributes()
        {
            return await _context.Attributes.ToListAsync();
        }

        // GET: api/Attributes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Attributes>> GetAttributes(int id)
        {
            var attributes = await _context.Attributes.FindAsync(id);

            if (attributes == null)
            {
                return NotFound();
            }

            return attributes;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAttributes(int id, AttributesDTO attributesDTO)
        {
            Attributes attributes = _mapper.Map<Attributes>(attributesDTO);
            attributes.Pk_AttrId = id;
            _context.Entry(attributes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AttributesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(attributes);
        }

        // POST: api/Attributes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Attributes>> PostAttributes(AttributesDTO attributesDTO)
        {
            try
            {
                Attributes attributes = _mapper.Map<Attributes>(attributesDTO);
                _context.Attributes.Add(attributes);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetAttributes", new { id = attributes.Pk_AttrId }, attributes);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        // DELETE: api/Attributes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAttributes(int id)
        {
            var attributes = await _context.Attributes.FindAsync(id);
            if (attributes == null)
            {
                return NotFound();
            }

            _context.Attributes.Remove(attributes);
            await _context.SaveChangesAsync();

            return Ok(attributes);
        }

        private bool AttributesExists(int id)
        {
            return (_context.Attributes?.Any(e => e.Pk_AttrId == id)).GetValueOrDefault();
        }
    }
}
