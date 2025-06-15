using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Web.Helpers;
using System.Security.Claims;

namespace AgenciaTurismo.Web.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty] public string Username { get; set; } = "";
        [BindProperty] public string Password { get; set; } = "";
        public string? ErrorMessage { get; set; }

        public IActionResult OnGet() => Page();

        public async Task<IActionResult> OnPostAsync()
        {
            if (FakeUserStore.Users.TryGetValue(Username, out var pwd) && pwd == Password)
            {
                var claims = new List<Claim> { new(ClaimTypes.Name, Username) };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));

                return RedirectToPage("/Index");
            }

            ErrorMessage = "Usuário ou senha incorretos.";
            return Page();
        }
    }
}