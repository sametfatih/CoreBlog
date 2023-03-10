using CoreLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment: IEntity
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentUserName { get; set; }
        public string CommentUserMail { get; set; }
        public string CommentContent { get; set; }
        public int CommentRate { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }=false;
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
