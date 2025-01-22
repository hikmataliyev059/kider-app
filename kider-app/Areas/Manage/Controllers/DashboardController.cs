using Microsoft.AspNetCore.Mvc;

namespace kider_app.Areas.Manage.Controllers;
[Area("Manage")]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
