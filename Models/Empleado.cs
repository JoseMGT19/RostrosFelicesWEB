namespace RostrosFelicesWEB.Models
{
	public class Empleado
	{
		public int Id { get; set; }
		public string Nombre { get; set; }

		public ICollection<Servicio>? Servicios { get; set; } = default;
	}
}
