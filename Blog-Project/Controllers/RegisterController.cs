using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;

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
            AuthorValidator authorValidator = new AuthorValidator();
            ValidationResult results= authorValidator.Validate(author);   

            if(results.IsValid) {
				
				_authorManager.Add(author);
				return RedirectToAction("Index", "Blog");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
		}
	}
}
