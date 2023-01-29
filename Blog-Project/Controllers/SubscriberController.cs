using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.Controllers
{
	[AllowAnonymous]
	public class SubscriberController : Controller
	{
		SubscriberManager _subscriberManager = new SubscriberManager(new EfSubscriberDal());
		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult SubscribeMail(Subscriber subscriber)
		{
			if (_subscriberManager.CheckMail(subscriber))
			{
				_subscriberManager.Add(subscriber);
				return Json(new { result = 1, message = "*Abone olduğunuz için teşekkür ederiz." });
			}

			return Json(new { result = 1, message = "*Bu mail adresi sistemimizde kayıtlıdır." });

		}
	}
}
