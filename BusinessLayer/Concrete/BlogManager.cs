using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(EfBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void Add(Blog entity)
		{
			_blogDal.Add(entity);
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetAll()
		{
			return _blogDal.GetAll();
		}

		public List<Blog> GetAllWithCategory()
		{
			return _blogDal.GetAllWithCategory(b=>b.BlogStatus==true);
		}

        public IEnumerable<Blog> GetBlogsForAuthorIdTake6(int id)
        {
            return _blogDal.GetAllWithCategory(b=>b.AuthorId== id && b.BlogStatus==true).Take(6);
        }
		public IEnumerable<Blog> GetBlogsForAuthorId(int id)
        {
            return _blogDal.GetAllWithCategory(b=>b.AuthorId== id);
        }

        public Blog GetByID(int id)
		{
			return _blogDal.Get(b => b.BlogId == id);
		}

        public IEnumerable<Blog> GetNewBlogs(int number)
        {
			return _blogDal.GetAll(b=> b.BlogStatus==true).OrderByDescending(b => b.BlogCreateDate).Take(number);
		}

        public void Update(Blog entity)
		{
			_blogDal.Update(entity);
		}

        public IEnumerable<Blog> GetBlogsWithAuthorAndCategory()
        {
			return _blogDal.GetBlogsWithAuthorAndCategory(b => b.BlogStatus == true).OrderByDescending(b => b.BlogCreateDate).Take(5);
        }
    }
}
