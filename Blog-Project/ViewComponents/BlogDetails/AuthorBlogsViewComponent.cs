using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.ViewComponents.BlogDetails
{
    public class AuthorBlogsViewComponent : ViewComponent
    {
       BlogManager blogManager = new BlogManager(new EfBlogDal());
        public IViewComponentResult Invoke(int id)
        {
            var blogs=blogManager.GetBlogsForAuthorIdTake6(id);
            return View(blogs);
        }
    }
}
