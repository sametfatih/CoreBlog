using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.Controllers
{
	[AllowAnonymous]
	public class CommentController : Controller
	{
		CommentManager _commentManager = new CommentManager(new EfCommentDal());

		[HttpPost]
		public IActionResult AddComment(Comment comment)
		{
			_commentManager.Add(comment);
			return Json(new { result = 1, message = "*Yorumunuz onaylandığında yorumlar kısmında görünecektir." });
		}
	}
}
