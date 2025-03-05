using Microsoft.AspNetCore.Mvc;


namespace WebApplication8.Controllers
{
    public class LibraryController : Controller
 {
         private const bool por = true;
    private const bool Khali = false;

   
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Select()
        {
            return View();
        }
       
        
    }
}
