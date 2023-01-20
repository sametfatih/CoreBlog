using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;

namespace Blog_Project.Controllers
{
    public class RegisterController : Controller
    {
        AuthorManager _authorManager = new AuthorManager(new EfAuthorDal());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
		[HttpPost]
		public IActionResult Index(Author author)
		{
            author.AuthorStatus = true;
            _authorManager.Add(author);
			return RedirectToAction("Index","Blog");
		}
	}
}
