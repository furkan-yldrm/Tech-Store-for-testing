using Microsoft.AspNetCore.Mvc;

namespace WebAppProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
