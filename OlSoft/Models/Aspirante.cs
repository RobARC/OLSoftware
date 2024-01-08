using System;
using System.Collections.Generic;

namespace OLSofwareDos.Models
{
    public partial class Aspirante
    {
        public Aspirante()
        {
            PruebaSeleccions = new HashSet<PruebaSeleccion>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public virtual ICollection<PruebaSeleccion> PruebaSeleccions { get; set; }
    }
}
