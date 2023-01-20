﻿using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Concrete.EntityFramework;

namespace Blog_Project.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());

        public IActionResult Index()
        {
            var values=_categoryManager.GetAll();
            return View(values);
        }
    }
}
