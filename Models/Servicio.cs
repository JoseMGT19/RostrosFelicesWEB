namespace RostrosFelicesWEB.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
		public Cliente Cliente { get; set; } // Propiedad de navegación a Cliente
		public int EmpleadoId { get; set; }
		public Empleado Empleado { get; set; } // Propiedad de navegación a Empleado

        //public ICollection<Servicio>? Servicios { get; set; } = default;
    }
}