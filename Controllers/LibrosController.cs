using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
namespace MiBibliotecaAPI.Controllers
{
    public class LibrosController
    {
        
    }
}*/


using Microsoft.AspNetCore.Mvc;
using MiBibliotecaAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MiBibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly MiBibliotecaContext _context;

        public LibrosController(MiBibliotecaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetLibros()
        {
            return Ok(await _context.Libros.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLibro(int id)
        {
            var libro = await _context.Libros.FindAsync(id);
            if (libro == null) return NotFound();
            return Ok(libro);
        }

        [HttpPost]
        public async Task<IActionResult> PostLibro(Libro libro)
        {
            _context.Libros.Add(libro);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetLibro", new { id = libro.Id }, libro);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutLibro(int id, Libro libro)
        {
            if (id != libro.Id) return BadRequest();
            _context.Entry(libro).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLibro(int id)
        {
            var libro = await _context.Libros.FindAsync(id);
            if (libro == null) return NotFound();
            _context.Libros.Remove(libro);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
