using Microsoft.EntityFrameworkCore;
using RostrosFelicesWEB.Models;

namespace RostrosFelicesWEB.Data
{
    public class RostrosFelicesContext : DbContext
    {
        public RostrosFelicesContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
    }
}
