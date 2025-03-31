using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
namespace WebApplication8.Controllers
{
    public class MainPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Main() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult File()
        {
            return View();
        }
        public IActionResult Fale()
        {
            return View();
        }
       
        public IActionResult labtab()
        {
            return View();
        }
          
       public IActionResult univercities()
        {
            return View();
        }

        public IActionResult newuniver()
        {
            return View();
        }
        }
    }

