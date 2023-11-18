namespace RostrosFelicesWEB.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public int EmpleadoId { get; set; }
    }
}