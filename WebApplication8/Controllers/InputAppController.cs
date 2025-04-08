using Microsoft.AspNetCore.Mvc;
using InputApp.Models;
using InputApp;
using WebApplication8.Data;
using Microsoft.EntityFrameworkCore.Design;

using Microsoft.EntityFrameworkCore; // ← این using مهم است!


using System.Threading.Tasks;

namespace InputApp.Controllers
{
    public class InputController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InputController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(InputData inputData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inputData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Success));
            }
            return View(inputData);
        }

        public IActionResult Success()
        {
            return View();
        }
       
     


    
}
  


    
}
