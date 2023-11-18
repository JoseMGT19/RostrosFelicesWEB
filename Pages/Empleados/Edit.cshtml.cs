using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RostrosFelicesWEB.Data;
using RostrosFelicesWEB.Models;

namespace RostrosFelicesWEB.Pages.Empleados
{
    public class EditModel : PageModel
    {
		private readonly RostrosFelicesContext _context;

		public EditModel(RostrosFelicesContext context)
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

			var empleados = await _context.Empleados.FirstOrDefaultAsync(m => m.Id == id);

			if (empleados == null)
			{
				return NotFound();
			}
			Empleados = empleados;
			return Page();



		}
		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			_context.Attach(Empleados).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!EmpleadosExists(Empleados.Id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}

			}
			return RedirectToPage("./Index");

		}

		private bool EmpleadosExists(int id)
		{
			return (_context.Empleados?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
