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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(EfCommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment entity)
        {
            _commentDal.Add(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAll()
        {
            return _commentDal.GetAll();
        }

        public List<Comment> GetAllByBlogId(int id)
        {
            return _commentDal.GetAll(c => c.BlogId == id && c.CommentStatus == true);
        }

        public Comment GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int GetCommentCountByBlogId(int id)
        {
            return _commentDal.GetAll(c => c.BlogId == id && c.CommentStatus == true).Count();
        }

        public int GetLikeCountByBlogId(int id)
        {
            return _commentDal.GetAll(c => c.BlogId == id && c.CommentRate == 1 && c.CommentStatus == true).Count();
        }

        public void Update(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
