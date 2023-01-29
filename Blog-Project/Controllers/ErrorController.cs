using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.Controllers
{
	[AllowAnonymous]
	public class ErrorController : Controller
	{
		public IActionResult Error(int code)
		{
			return View();
		}
	}
}
