using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.ViewComponents.BlogDetails
{
	public class LeaveACommentViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke(int id)
		{
			ViewBag.blogId = id;
			return View();
		}
	}
}
