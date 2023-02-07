using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.ViewComponents.AuthorPanel
{
    public class AuthorNewBlogsViewComponent : ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        public IViewComponentResult Invoke()
        {
            var blogs = blogManager.GetBlogsWithAuthorAndCategory();
            return View(blogs);
        }
    }
}
