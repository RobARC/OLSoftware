using System;
using System.Collections.Generic;

namespace OLSofwareDos.Models
{
    public partial class Pregunta
    {
        public int Id { get; set; }
        public string Pregunta1 { get; set; } = null!;
        public string? Respuesta { get; set; }
        public int PruebaSeleccionId { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual PruebaSeleccion PruebaSeleccion { get; set; } = null!;
        public virtual Usuario? Usuario { get; set; }
    }
}
