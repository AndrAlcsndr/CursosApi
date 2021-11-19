using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaCursosController : ControllerBase
    {
        private readonly CursosCastContext _context;

        public CategoriaCursosController(CursosCastContext context)
        {
            _context = context;
        }

        // GET: api/CategoriaCursos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaCursos>>> GetCategorias()
        {
            return await _context.Categorias.ToListAsync();
        }

        // GET: api/CategoriaCursos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriaCursos>> GetCategoriaCursos(int id)
        {
            var categoriaCursos = await _context.Categorias.FindAsync(id);

            if (categoriaCursos == null)
            {
                return NotFound();
            }

            return categoriaCursos;
        }

        // PUT: api/CategoriaCursos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoriaCursos(int id, CategoriaCursos categoriaCursos)
        {
            if (id != categoriaCursos.CategoriaId)
            {
                return BadRequest();
            }

            _context.Entry(categoriaCursos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriaCursosExists(id))
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

        // POST: api/CategoriaCursos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CategoriaCursos>> PostCategoriaCursos(CategoriaCursos categoriaCursos)
        {
            _context.Categorias.Add(categoriaCursos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategoriaCursos", new { id = categoriaCursos.CategoriaId }, categoriaCursos);
        }

        // DELETE: api/CategoriaCursos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoriaCursos(int id)
        {
            var categoriaCursos = await _context.Categorias.FindAsync(id);
            if (categoriaCursos == null)
            {
                return NotFound();
            }

            _context.Categorias.Remove(categoriaCursos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategoriaCursosExists(int id)
        {
            return _context.Categorias.Any(e => e.CategoriaId == id);
        }
    }
}
