using backend_locadora.Data;
using backend_locadora.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_locadora.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaVeiculoesController : Controller
    {
        private readonly AppDbContext _context;

        public CategoriaVeiculoesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaVeiculo>>> GetCategoriaVeiculos()
        {
            return await _context.CategoriaVeiculo.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriaVeiculo>> GetCategoriaVeiculoPorId(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var categoriaVeiculo = await _context.CategoriaVeiculo.FindAsync(id);

            if (categoriaVeiculo == null)
            {
                return NotFound();
            }

            return categoriaVeiculo;
        }

        [HttpPost]
        public async Task<ActionResult<CategoriaVeiculo>> PostCategoriaVeiculo(CategoriaVeiculo categoriaVeiculo)
        {
            _context.CategoriaVeiculo.Add(categoriaVeiculo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategoriaVeiculoPorId", new { id = categoriaVeiculo.IdCategoriaVeiculo }, categoriaVeiculo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoriaVeiculo(int id, CategoriaVeiculo categoriaVeiculo)
        {
            if (id != categoriaVeiculo.IdCategoriaVeiculo)
            {
                return BadRequest();
            }

            _context.Entry(categoriaVeiculo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriaVeiculoExists(id))
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

        private bool CategoriaVeiculoExists(int id)
        {
            return _context.CategoriaVeiculo.Any(e => e.IdCategoriaVeiculo == id);
        }
    }
}