using CoreLayer.Business.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IService<Blog>
    {
        List<Blog> GetAllWithCategory();
        IEnumerable<Blog> GetBlogsForAuthorId(int id);
        IEnumerable<Blog> GetNewBlogs(int number);
    }
}
