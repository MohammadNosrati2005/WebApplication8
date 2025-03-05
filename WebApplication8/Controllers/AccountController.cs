using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;

namespace LoginApp.Controllers
{
    public class AccountController : Controller
    {
        // Hardcoded credentials for demonstration
        private const string ValidUsername = "admin";
        private const string ValidPassword = "password123";

        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login( String username , string password)
        {
           if(username== ValidUsername && password== ValidPassword) 
            {
                // Redirect to a success page or home page
                return RedirectToAction("Select", "Library");
            }
            else
            {
                // Show an error message
                ViewBag.ErrorMessage = "نام کاربری یا گذرواژه صحیح نمی‌باشد.";
                return View();
            }
        }
    }
}