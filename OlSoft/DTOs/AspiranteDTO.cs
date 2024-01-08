﻿using OLSofwareDos.Models;

namespace OlSoft.DTOs
{
    public class AspiranteDTO
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaActualizacion { get; set; }
       
    }
}
