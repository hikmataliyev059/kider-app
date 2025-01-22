using kider_app.DAL.Context;
using kider_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kider_app.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        ICollection<Agent> agents = await _context.Agents
             .Include(x => x.Position)
             .ToListAsync();
        return View(agents);
    }
}
