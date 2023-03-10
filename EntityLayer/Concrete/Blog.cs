using CoreLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog: IEntity
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogContentText { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public string BlogImagePath { get; set; }
        public string BlogThumbnailImagePath { get; set; }
        public int BlogRating { get; set; }
        public bool BlogStatus { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
