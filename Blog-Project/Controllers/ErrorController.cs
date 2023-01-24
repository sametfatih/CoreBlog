using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.Controllers
{
	public class ErrorController : Controller
	{
		public IActionResult Error(int code)
		{
			return View();
		}
	}
}
