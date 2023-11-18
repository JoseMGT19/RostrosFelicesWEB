using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RostrosFelicesWEB.Data;
using RostrosFelicesWEB.Models;

namespace RostrosFelicesWEB.Pages.Empleados
{
    public class CreateModel : PageModel
    {
        private readonly RostrosFelicesContext _context;

        public CreateModel(RostrosFelicesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]

        public Empleado Empleados { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Empleados == null || Empleados == null)
            {
                return Page();
            }
            _context.Empleados.Add(Empleados);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
