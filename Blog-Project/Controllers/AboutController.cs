using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.Controllers
{
	public class AboutController : Controller
	{
		AboutManager _aboutManager = new AboutManager(new EfAboutDal());
		public IActionResult Index()
		{
			var about = _aboutManager.GetByID(1);
			return View(about);
		}
	}
}
