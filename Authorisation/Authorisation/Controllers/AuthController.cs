using Authorisation.Model;
using Authorisation.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorisation.Controllers
{
    public class AuthController : Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginForm loginForm)
        {
            var result = await _signInManager.PasswordSignInAsync(loginForm.Username,
                   loginForm.Password, true, false);

            if (result.Succeeded)
            {
                return Redirect("/Home");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterForm registerForm)
        {
            try
            {
                AppUser user = new AppUser()
                {
                    UserName = registerForm.Name,
                    Email = registerForm.Email
                };

                //Wat doet de await?
                var result = await _userManager.CreateAsync(user, registerForm.Password);

                //Als het gelukt is om de gebruiker aan te maken, kunnen we hem meteen inloggen.
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return Redirect("/home");

                }

                return View();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
    
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
           await  _signInManager.SignOutAsync();
           return Redirect("/home");
        }
    }
}
