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
        IEnumerable<Blog> GetBlogsForAuthorIdTake6(int id);
        IEnumerable<Blog> GetNewBlogs(int number);
        IEnumerable<Blog> GetBlogsWithAuthorAndCategory();
        Blog GetBlogByIdWithAuthorAndCategory(int id);
    }
}
