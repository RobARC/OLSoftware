namespace OlSoft.DTOs
{
    public class PruebasDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public int AspiranteId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string LenguajeProgramacion { get; set; } = null!;
        public int CantidadPreguntas { get; set; }
        public int TipoPruebaId { get; set; }
        public int NivelPruebaId { get; set; }
        public int EstadoPruebaId { get; set; }
        public decimal Calificacion { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
