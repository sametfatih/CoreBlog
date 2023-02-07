using BusinessLayer.Concrete;
using CoreLayer.Utility.Html;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Blog_Project.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new EfBlogDal());
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());

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
        public IActionResult AuthorBlogList()
        {
            var blogs = _blogManager.GetBlogsForAuthorId(1);
            return View(blogs);
        }
        [HttpGet]
        public IActionResult AuthorBlogAdd()
        {
            List<SelectListItem> categoryList = (from c in _categoryManager.GetAll()
                                                 select new SelectListItem
                                                 {
                                                     Text = c.CategoryName,
                                                     Value = c.CategoryId.ToString(),

                                                 }).ToList();

            ViewBag.categoryList = categoryList;

            return View();
        }
        [HttpPost]
        public IActionResult AuthorBlogAdd(Blog blog)
        {
            blog.BlogContentText = HtmlUtilities.ConvertToPlainText(blog.BlogContent);
            //_blogManager.Add(blog);
            return RedirectToAction("AuthorBlogList");
        }
        [HttpGet]
        public IActionResult AuthorBlogUpdate(int id)
        {
            List<SelectListItem> categoryList = (from c in _categoryManager.GetAll()
                                                 select new SelectListItem
                                                 {
                                                     Text = c.CategoryName,
                                                     Value = c.CategoryId.ToString(),

                                                 }).ToList();

            ViewBag.categoryList = categoryList;

            var blog = _blogManager.GetByID(id);
            return View(blog);

        }
        [HttpPost]
        public IActionResult AuthorBlogUpdate(Blog blog)
        {
            blog.BlogContentText = HtmlUtilities.ConvertToPlainText(blog.BlogContent);
            _blogManager.Update(blog);
            return RedirectToAction("AuthorBlogList");

        }

        public IActionResult BlogPreview(Blog blog)
        {
            if (blog.AuthorId != 0)
            {
                return View(blog);
            }
            return NotFound();
            
        }
        [HttpPost]
        public IActionResult BlogPreview2(Blog blog)
        {
            return Json(new { OpenUrl = Url.Action("BlogPreview", "Blog", blog) });
        }
    }
}
