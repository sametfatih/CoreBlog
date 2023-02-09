using CoreLayer.DataAccess;
using CoreLayer.Entity;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal:IRepository<Blog>
    {
        List<Blog> GetAllWithCategory(Expression<Func<Blog, bool>> filter = null);
        IEnumerable<Blog> GetBlogsWithAuthorAndCategory(Expression<Func<Blog, bool>> filter = null);
        Blog GetBlogByIdWithAuthorAndCategory(Expression<Func<Blog, bool>> filter = null);
    }
}
