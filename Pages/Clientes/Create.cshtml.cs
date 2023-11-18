using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RostrosFelicesWEB.Data;
using RostrosFelicesWEB.Models;

namespace RostrosFelicesWEB.Pages.Clientes
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

        public Cliente Clientes { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid || _context.Clientes == null || Clientes== null) 
            {
                return Page();
            }
            _context.Clientes.Add(Clientes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
