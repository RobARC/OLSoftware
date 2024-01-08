using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Converters;
using OlSoft.DTOs;
using OLSofwareDos.Context;
using OLSofwareDos.Models;
using System.Drawing.Printing;
using System.Text.Json.Serialization;

namespace OlSoft.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    [Route("api/[controller]")]
    [ApiController]
    public class PruebaSeleccionController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PruebaSeleccionController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        // GET: api/PruebasSeleccion

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PruebasDTO>>> GetPruebasSeleccion()
        {

            var pruebas = await _context.PruebaSeleccions.ToListAsync();

            var pruebasDTO = _mapper.Map<List<PruebasDTO>>(pruebas);

            if (pruebas == null)
            {
                return NotFound();
            }

            return Ok(pruebasDTO);
        }

        // GET: api/PruebasSeleccion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PruebasDTO>> GetPruebaSeleccion(int id)
        {
            if (_context.PruebaSeleccions == null)
            {
                return NotFound();
            }

            var prueba = await _context.PruebaSeleccions.FindAsync(id);

            var pruebasDTO = _mapper.Map<PruebasDTO>(prueba);

            if (prueba == null)
            {
                return NotFound();
            }

            return Ok(pruebasDTO);
        }

        // PUT: api/PruebasSeleccion/5
        [HttpPut("{id}")]
        public async Task<ActionResult<PruebasDTO>> PutPruebaSeleccion(int id, [FromBody] PruebasDTO pruebasDTO)
        {

            if (id != pruebasDTO.Id)
            {
                return BadRequest();
            }

            var pruebaExistente = await _context.PruebaSeleccions.FindAsync(id);

            if(pruebaExistente == null)
            {
                return NotFound();
            }

            _mapper.Map(pruebasDTO, pruebaExistente);
            pruebaExistente.FechaActualizacion = DateTime.Now;
            _context.Entry(pruebaExistente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PruebaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            var pruebaExistenteDTO = _mapper.Map<PruebaSeleccion, PruebasDTO>(pruebaExistente);
            return Ok(new { message = "Update Successfully!", data = pruebaExistenteDTO });
        }

        // POST: api/PruebasSeleccion
        [HttpPost]
        public async Task<ActionResult> PostPruebas([FromBody]  PruebasDTO pruebaDTO)
        {
            DateTime fechaInicio = DateTime.Now;
            DateTime fechaFin = DateTime.Now;
            DateTime fechaActualizacion = DateTime.Now;

            var pruebaSeleccion = new PruebaSeleccion
            {
                Descripcion = pruebaDTO.Descripcion,
                AspiranteId = pruebaDTO.AspiranteId,
                FechaInicio = fechaInicio,
                FechaFin = fechaFin,
                LenguajeProgramacion = pruebaDTO.LenguajeProgramacion,
                CantidadPreguntas = pruebaDTO.CantidadPreguntas,
                TipoPruebaId = pruebaDTO.TipoPruebaId,
                NivelPruebaId = pruebaDTO.NivelPruebaId,
                EstadoPruebaId = pruebaDTO.EstadoPruebaId,
                Calificacion = pruebaDTO.Calificacion,
                FechaActualizacion = fechaActualizacion
            };

            _context.PruebaSeleccions.Add(pruebaSeleccion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPruebasSeleccion", new { id = pruebaSeleccion.Id },
                new { message = "Creation Successfully!", data = pruebaDTO });
        }

        // DELETE: api/Aspirantes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrueba(int id)
        {
            if (_context.PruebaSeleccions == null)
            {
                return NotFound();
            }

            var prueba = await _context.PruebaSeleccions.FindAsync(id);
            if (prueba == null)
            {
                return NotFound();
            }

            _context.PruebaSeleccions.Remove(prueba);
            await _context.SaveChangesAsync();

            return NoContent();

        }

        private bool PruebaExists(int id)
        {
            return (_context.PruebaSeleccions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
