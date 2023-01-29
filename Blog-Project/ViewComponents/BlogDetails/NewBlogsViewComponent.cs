using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.ViewComponents.BlogDetails
{
    public class NewBlogsViewComponent : ViewComponent 
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());

        public IViewComponentResult Invoke()
        {
            var blogs = blogManager.GetNewBlogs(6);
            return View(blogs);
        }
    }
}
