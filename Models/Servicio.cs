namespace RostrosFelicesWEB.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
		public Cliente Clientes { get; set; } // Propiedad de navegación a Cliente
		public int EmpleadoId { get; set; }
		public Empleado Empleados { get; set; } // Propiedad de navegación a Empleado
	}
}