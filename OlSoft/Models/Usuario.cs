using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OLSofwareDos.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Aspirantes = new HashSet<Aspirante>();
            EstadoPruebas = new HashSet<EstadoPrueba>();
            NivelPruebas = new HashSet<NivelPrueba>();
            Pregunta = new HashSet<Pregunta>();
            PruebaSeleccions = new HashSet<PruebaSeleccion>();
            TipoPruebas = new HashSet<TipoPrueba>();
        }

        
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RoleId { get; set; }

        public virtual ICollection<Aspirante> Aspirantes { get; set; }
        public virtual ICollection<EstadoPrueba> EstadoPruebas { get; set; }
        public virtual ICollection<NivelPrueba> NivelPruebas { get; set; }
        public virtual ICollection<Pregunta> Pregunta { get; set; }
        public virtual ICollection<PruebaSeleccion> PruebaSeleccions { get; set; }
        public virtual ICollection<TipoPrueba> TipoPruebas { get; set; }
    }
}
