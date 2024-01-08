using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OlSoft.DTOs;
using OlSoft.Migrations;
using OLSofwareDos.Context;
using OLSofwareDos.Models;

namespace OlSoft.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    [Route("api/[controller]")]
    [ApiController]
    public class AspirantesController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AspirantesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Aspirantes

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AspiranteDTO>>> GetAspirantes()
        {
            var aspirantes = await _context.Aspirantes.ToListAsync();
            var aspirantesDTO = _mapper.Map<List<AspiranteDTO>>(aspirantes);
            
            if (aspirantes == null)
            {
                return NotFound();
            }

            return Ok(aspirantesDTO);
        }

        // GET: api/Aspirantes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AspiranteDTO>> GetAspirante(int id)
        {
            if (_context.Aspirantes == null)
            {
                return NotFound();
            }

            var aspirante = await _context.Aspirantes.FindAsync(id);

            var aspiranteDTO = _mapper.Map<AspiranteDTO>(aspirante);
            
            if (aspirante == null)
            {
                return NotFound();
            }

            return Ok(aspiranteDTO);
        }

        // PUT: api/Aspirantes/5
        [HttpPut("{id}")]
        public async Task<ActionResult<AspiranteDTO>> PutAspirante(int id, [FromBody] AspiranteDTO aspiranteDTO)
        {
            if (id != aspiranteDTO.Id)
            {
                return BadRequest();
            }

            var aspiranteExistente = await _context.Aspirantes.FindAsync(id);

            if (aspiranteExistente == null)
            {
                return NotFound();
            }

            _mapper.Map(aspiranteDTO, aspiranteExistente);
            aspiranteExistente.FechaActualizacion = DateTime.Now;
            _context.Entry(aspiranteExistente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AspiranteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            var aspiranteExistenteDTO = _mapper.Map<Aspirante, AspiranteDTO>(aspiranteExistente);
            return Ok(new { messege = "Update Successfully!", data = aspiranteExistenteDTO });
        }

        // POST: api/Aspirantes
        [HttpPost]
        public async Task<ActionResult> PostEmpleados([FromBody] AspiranteDTO aspiranteDTO)
        {
           
            DateTime fechaActualizacion = DateTime.Now;

            var aspirante = new Aspirante
            {
                Nombre = aspiranteDTO.Nombre,
                Apellido = aspiranteDTO.Apellido,
                Telefono = aspiranteDTO.Telefono,
                Email = aspiranteDTO.Email,
                UsuarioId = aspiranteDTO.UsuarioId,
                FechaActualizacion = fechaActualizacion
            };

            _context.Aspirantes.Add(aspirante);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAspirantes", new { id = aspirante.Id }, 
                new {messege = "Creation Successfully!", data = aspiranteDTO});
        }


        // DELETE: api/Aspirantes/5
        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteAspirante(int id)
        {
            if (_context.Aspirantes == null)
            {
                return NotFound();
            }

            var aspirante = await _context.Aspirantes.FindAsync(id);
            if (aspirante == null)
            {
                return NotFound();
            }

            _context.Aspirantes.Remove(aspirante);
            await _context.SaveChangesAsync();

            return NoContent();

        }
           
        private bool AspiranteExists(int id)
        {
            return (_context.Aspirantes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
