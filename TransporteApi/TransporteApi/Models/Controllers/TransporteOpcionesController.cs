using Microsoft.AspNetCore.Mvc;
using TransporteApi.Controllers;
using TransporteApi.Data;
using Microsoft.EntityFrameworkCore;

namespace TransporteApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransporteOpcionesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TransporteOpcionesController(AppDbContext context)
        {
            _context = context;
        }

      
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransporteOpcion>>> GetOpciones()
        {
            return await _context.TransporteOpciones.ToListAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<TransporteOpcion>> GetOpcion(int id)
        {
            var opcion = await _context.TransporteOpciones.FindAsync(id);
            if (opcion == null) return NotFound();
            return opcion;
        }

        
        [HttpPost]
        public async Task<ActionResult<TransporteOpcion>> PostOpcion(TransporteOpcion opcion)
        {
            _context.TransporteOpciones.Add(opcion);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetOpcion), new { id = opcion.Id }, opcion);
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOpcion(int id, TransporteOpcion opcion)
        {
            if (id != opcion.Id) return BadRequest();
            _context.Entry(opcion).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOpcion(int id)
        {
            var opcion = await _context.TransporteOpciones.FindAsync(id);
            if (opcion == null) return NotFound();
            _context.TransporteOpciones.Remove(opcion);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
