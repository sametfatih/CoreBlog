using CoreLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Author : IEntity
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorAbout { get; set; }
        public string AuthorImagePath { get; set; }
        public string AuthorMail { get; set; }
        public string AuthorPassword { get; set; }
        public int AuthorRating { get; set; }
        public bool AuthorStatus { get; set; } = false;
        public List<Blog> Blogs { get; set; }
    }
}
