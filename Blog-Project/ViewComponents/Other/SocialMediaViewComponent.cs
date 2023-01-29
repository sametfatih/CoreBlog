using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.ViewComponents.Other
{
	public class SocialMediaViewComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
