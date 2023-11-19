using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RostrosFelicesWEB.Data;
using RostrosFelicesWEB.Models;

namespace RostrosFelicesWEB.Pages.Servicios
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

        public Servicio Servicios { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Servicios == null || Servicios == null)
            {
                return Page();
            }
            _context.Servicios.Add(Servicios);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
