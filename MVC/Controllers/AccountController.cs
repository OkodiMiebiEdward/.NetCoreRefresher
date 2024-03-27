using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult details()
        {
            return View();
        }
    }
}
