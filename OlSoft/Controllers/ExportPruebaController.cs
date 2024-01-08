using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OLSofwareDos.Context;
using OLSofwareDos.Models;


namespace OlSoft.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    [Route("api/[controller]")]
    [ApiController]
    public class ExportPruebaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        

        public ExportPruebaController(ApplicationDbContext context)
        {
            _context = context;
                      
        }

        [HttpGet]
        public async Task<IActionResult> ExportPruebaSeleccion()
        {
            var pruebasSeleccion = await _context.PruebaSeleccions.Include(
                p => p.Pregunta).ToListAsync();

            var folderPath = @"C:\Users\Roberth\OLSoftware\OlSoft\ExportedFiles";

            // Crea una carpeta para almacenar los archivos, si aún no existe
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Crea un archivo plano con la información de las pruebas de selección
            var filePath = Path.Combine(folderPath, "PruebasSeleccion.txt");
            using (var writer = new StreamWriter(filePath))
            {
                foreach (var prueba in pruebasSeleccion)
                {
                    await writer.WriteLineAsync($"Id: {prueba.Id}, Descripcion: {prueba.Descripcion}, AspiranteId: {prueba.AspiranteId}, FechaInicio: {prueba.FechaInicio}, FechaFin: {prueba.FechaFin}, LenguajeProgramacion: {prueba.LenguajeProgramacion}, CantidadPreguntas: {prueba.CantidadPreguntas}, TipoPruebaId: {prueba.TipoPruebaId}, NivelPruebaId: {prueba.NivelPruebaId}, EstadoPruebaId: {prueba.EstadoPruebaId}, Calificacion: {prueba.Calificacion}, UsuarioId: {prueba.UsuarioId}, FechaActualizacion: {prueba.FechaActualizacion}");
                    foreach (var pregunta in prueba.Pregunta)
                    {
                        await writer.WriteLineAsync($"\tPreguntaId: {pregunta.Id}, Pregunta: {pregunta.Pregunta1}, Respuesta: {pregunta.Respuesta}, UsuarioId: {pregunta.UsuarioId}, FechaActualizacion: {pregunta.FechaActualizacion}");
                    }
                }
            }

            return Ok(
                new { 
                message = "Archivo generado correctamente", 
                filePath = filePath 
                });
        }
    }
}
