using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
	public class EfBlogDal : EfBaseRepository<Blog, Context>, IBlogDal
	{
		public List<Blog> GetAllWithCategory()
		{
			using(var context = new Context())
			{
				return context.Blogs.Include(b => b.Category).ToList();
			}
		}
	}
}
