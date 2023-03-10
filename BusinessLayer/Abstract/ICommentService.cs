using CoreLayer.Business.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService:IService<Comment>
    {
        List<Comment> GetAllByBlogId(int id);
        int GetCommentCountByBlogId(int id);
        int GetLikeCountByBlogId(int id);
       
    }
}
