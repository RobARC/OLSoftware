using System;
using System.Collections.Generic;

namespace OLSofwareDos.Models
{
    public partial class PruebaSeleccion
    {
        public PruebaSeleccion()
        {
            Pregunta = new HashSet<Pregunta>();
        }

        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public int AspiranteId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? LenguajeProgramacion { get; set; }
        public int? CantidadPreguntas { get; set; }
        public int? TipoPruebaId { get; set; }
        public int? NivelPruebaId { get; set; }
        public int? EstadoPruebaId { get; set; }
        public decimal? Calificacion { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Aspirante Aspirante { get; set; } = null!;
        public virtual EstadoPrueba? EstadoPrueba { get; set; }
        public virtual NivelPrueba? NivelPrueba { get; set; }
        public virtual TipoPrueba? TipoPrueba { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public virtual ICollection<Pregunta> Pregunta { get; set; }
    }
}
