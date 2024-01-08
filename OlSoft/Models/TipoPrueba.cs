﻿using System;
using System.Collections.Generic;

namespace OLSofwareDos.Models
{
    public partial class TipoPrueba
    {
        public TipoPrueba()
        {
            PruebaSeleccions = new HashSet<PruebaSeleccion>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; } = null!;
        public int? UsuarioId { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Usuario? Usuario { get; set; }
        public virtual ICollection<PruebaSeleccion> PruebaSeleccions { get; set; }
    }
}
