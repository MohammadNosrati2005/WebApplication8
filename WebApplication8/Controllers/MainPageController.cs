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
       
        
            public IActionResult Labtab()
            {
                var products = new List<Product>
        {
            new Product { Id = 1, firstname= "mohammad"  },
            new Product { Id = 2, firstname = "nosrati"   }
        };

                return View(products);
            }
        }
    }

