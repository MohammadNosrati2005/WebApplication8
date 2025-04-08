using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using InputApp.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using WebApplication8.Data;

public class InputAppController : Controller
{
    private readonly ApplicationDbContext _context;

    public InputAppController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: InputApp
    public async Task<IActionResult> universities()
    {
        var inputDataList = await _context.inputDatas.ToListAsync();
        return View(inputDataList); // ارسال لیست به ویو
    }
}