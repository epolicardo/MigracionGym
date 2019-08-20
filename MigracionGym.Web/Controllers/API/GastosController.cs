using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MigracionGym.Web.Data;
using MigracionGym.Web.Data.Entities;

namespace MigracionGym.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class GastosController : Controller
    {
        private readonly IRepositorio_Gastos repositorio;

        public GastosController(IRepositorio_Gastos repositorio)
        {
            this.repositorio = repositorio;
        }

        // GET: api/Gastos
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.repositorio.getAll());
        }

        //// GET: api/Gastos/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Gastos>> GetGastos(int id)
        //{
        //    var gastos = await _context.gastos.FindAsync(id);

        //    if (gastos == null)
        //    {
        //        return NotFound();
        //    }

        //    return gastos;
        //}

        //// PUT: api/Gastos/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutGastos(int id, Gastos gastos)
        //{
        //    if (id != gastos.id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(gastos).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!GastosExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Gastos
        //[HttpPost]
        //public async Task<ActionResult<Gastos>> PostGastos(Gastos gastos)
        //{
        //    _context.gastos.Add(gastos);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetGastos", new { id = gastos.id }, gastos);
        //}

        //// DELETE: api/Gastos/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Gastos>> DeleteGastos(int id)
        //{
        //    var gastos = await _context.gastos.FindAsync(id);
        //    if (gastos == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.gastos.Remove(gastos);
        //    await _context.SaveChangesAsync();

        //    return gastos;
        //}

        //private bool GastosExists(int id)
        //{
        //    return _context.gastos.Any(e => e.id == id);
        //}
    }
}
