using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RetroGame_Cafe.BLL.Interfaces;
using RetroGame_Cafe.BLL.Models;
using RetroGame_Cafe.Models;
using System.Security.Claims;

namespace RetroGame_Cafe.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(MemberLoginForm data)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            MemberModel? mem = _authService.Login(data.Email, data.Password);

            if (mem is null)
            {
                ModelState.AddModelError(string.Empty, "L'Email ou le mot de passe est érroner");
                return View();
            }

            await CreatMemberSessionAsync(mem);

            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");
        }

        private async Task CreatMemberSessionAsync(MemberModel mem)
        {
            List<Claim> claims = [
                new Claim(ClaimTypes.NameIdentifier, mem.Pseudo),
                new Claim(ClaimTypes.Role, mem.Role)
            ];

            var indentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(indentity));
        }
    }
}
