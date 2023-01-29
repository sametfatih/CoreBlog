using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new EfBlogDal());

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BlogList()
        {
            var blogList = _blogManager.GetAllWithCategory();
            return View(blogList);
        }
        public IActionResult BlogDetails(int id)
        {
            ViewBag.urlId = id;
            var blog = _blogManager.GetByID(id);
            return View(blog);
        }
    }
}
