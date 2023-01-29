using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.ViewComponents.Blogs
{
	public class BlogListFooterViewComponent:ViewComponent
	{
		BlogManager _blogManager = new BlogManager(new EfBlogDal());
		public IViewComponentResult Invoke()
		{
			var blogs = _blogManager.GetNewBlogs(3);
			return View(blogs);
		}
	}
}
