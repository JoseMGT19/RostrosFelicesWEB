using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RostrosFelicesWEB.Data;
using RostrosFelicesWEB.Models;

namespace RostrosFelicesWEB.Pages.Empleados
{
    public class DeleteModel : PageModel
    {
        private readonly RostrosFelicesContext _context;

        public DeleteModel(RostrosFelicesContext context)
        {
            _context = context;
        }

        [BindProperty]

        public Empleado Empleados { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Empleados == null)
            {
                return NotFound();
            }

            var empleados = await _context.Empleados.FindAsync(id);

            if (empleados != null)
            {
                Empleados = empleados;
                _context.Empleados.Remove(Empleados);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}
