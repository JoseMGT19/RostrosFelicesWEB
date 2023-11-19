using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RostrosFelicesWEB.Data;
using RostrosFelicesWEB.Models;

namespace RostrosFelicesWEB.Pages.Servicios
{
    public class IndexModel : PageModel
    {
        private readonly RostrosFelicesContext _context;

        public IndexModel(RostrosFelicesContext context)
        {
            _context = context;
        }

        public IList<Servicio> Servicios { get; set; }

        public void OnGet()
        {
            Servicios = _context.Servicios
                .Include(s => s.Clientes)
                .Include(s => s.Empleados)
                .ToList();
        }
    }
}
