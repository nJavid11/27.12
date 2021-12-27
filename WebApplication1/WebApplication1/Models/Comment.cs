using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [MaxLength(100)]
        public string Subject { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        [ForeignKey("Comment")]
        public int CommentId { get; set; }
        public Comment CommentReply { get; set; }






    }
}
