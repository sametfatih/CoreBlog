using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
