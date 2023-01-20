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
			throw new NotImplementedException();
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
			return _blogDal.GetAllWithCategory();
		}

		public Blog GetByID(int id)
		{
			return _blogDal.Get(b => b.BlogId == id);
		}

		public void Update(Blog entity)
		{
			throw new NotImplementedException();
		}
	}
}
