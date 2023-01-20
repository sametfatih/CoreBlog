using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.ViewComponents.BlogDetails
{
	public class BlogCommentsViewComponent :ViewComponent
	{
		CommentManager commentManager = new CommentManager(new EfCommentDal());

		public IViewComponentResult Invoke(int id)
		{
			var commentsByBlog = commentManager.GetAllByBlogId(id);
			return View(commentsByBlog);
		}
	}
}
