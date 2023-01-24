using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.Controllers
{
	public class ContactController : Controller
	{
		ContactManager _contactManager = new ContactManager(new EfContactDal());
		ContactUsManager _contactUsManager = new ContactUsManager(new EfContactUsDal());
		public IActionResult Index()
		{
			var contact = _contactUsManager.GetByID(1);
			return View(contact);
		}
		public IActionResult AddContact(Contact contact)
		{
			_contactManager.Add(contact);
			return Json(new { result=1,message="Mesajınızı aldık. En kısa sürede email adresinize geri dönüş yapacağız."});
		}
	}
}
