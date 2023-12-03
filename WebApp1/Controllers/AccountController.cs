using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        public AccountController(UserManager<IdentityUser> userManager)
        {  _userManager = userManager; }
        public IActionResult GetAllUsers()
        {
            var users = _userManager.Users;
            return View(users);
        }
    }
}
