using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.ViewComponents.BlogDetails
{
    public class BlogCommentStatsViewComponent:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id,int display)
        {
            ViewBag.display=display;
            ViewBag.comment = commentManager.GetCommentCountByBlogId(id);
            ViewBag.like = commentManager.GetLikeCountByBlogId(id);
            return View();
        }
    }
}
