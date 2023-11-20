using RostrosFelicesWEB.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Models;
using System.Security.Claims;

namespace RostrosFelicesWEB.Pages.Account
{
	public class LoginModel : PageModel
	{
		[BindProperty]
		public User User { get; set; }
		public void OnGet()
		{

		}

		public async Task<IActionResult> OnPostAsync()
		{
			if (User.Email == "correo@gmail.com" && User.Password == "123456")
			{
				//se cre4a los claim, datos a almacenar en la cookie
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name, "admin"),
					new Claim(ClaimTypes.Email, User.Email),
				};
				//se asocia los claims ceados a un nombre de una cookie
				var identity = new ClaimsIdentity(claims, "MyCookiesAuth");
				//Se agrega la identidad creada al ClaimsPrincipal de la aplicacion
				ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

				//se registra exitosamente la autenticacion y se crea la cookie en el navegador
				await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);
				return RedirectToPage("/Index");
			}
			return Page();
		}
	}
}
