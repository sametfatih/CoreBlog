using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.ViewComponents.BlogDetails
{
	public class CategoriesViewComponent:ViewComponent
	{
		CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

		public IViewComponentResult Invoke()
		{
			var categoryList = categoryManager.GetAll();
			return View(categoryList);
		}
	}
}
