using CoreLayer.DataAccess.EntityFramework;
using CoreLayer.Entity;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfBlogDal : EfBaseRepository<Blog, Context>, IBlogDal
    {
        public List<Blog> GetAllWithCategory(Expression<Func<Blog, bool>> filter = null)
        {
            using (var context = new Context())
            {
                return filter == null ? context.Blogs.Include(b => b.Category).ToList(): context.Blogs.Include(b => b.Category).Where(filter).ToList();
            }
        }

        public Blog GetBlogByIdWithAuthorAndCategory(Expression<Func<Blog, bool>> filter = null)
        {
            using (var context = new Context())
            {
                return filter == null ? context.Blogs.Include(b => b.Author).Include(b => b.Category).SingleOrDefault() : context.Blogs.Include(b => b.Author).Include(b => b.Category).Where(filter).SingleOrDefault();
            }
        }

        public IEnumerable<Blog> GetBlogsWithAuthorAndCategory(Expression<Func<Blog, bool>> filter = null)
        {
            using (var context = new Context()) {
                return filter == null ? context.Blogs.Include(b=>b.Author).Include(b=>b.Category).ToList(): context.Blogs.Include(b => b.Author).Include(b => b.Category).Where(filter).ToList();
            }
        }
    }
}
