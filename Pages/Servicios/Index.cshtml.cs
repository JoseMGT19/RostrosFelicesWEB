using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RostrosFelicesWEB.Data;
using RostrosFelicesWEB.Models;

namespace RostrosFelicesWEB.Pages.Servicios
{
    [Authorize]
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
                .Include(s => s.Cliente)
                .Include(s => s.Empleado)
                .ToList();
        }
    }
}
