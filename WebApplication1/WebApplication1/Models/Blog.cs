using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Image { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [Column(TypeName ="ntext")]
        public string Content { get; set; }

        public DateTime CreateDate { get; set; }

        public int Views { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Popular> populars { get; set; }
        public List<LatestPost> latestPosts { get; set; }
        public List<BlogToTag> blogToTags { get; set; }

    }
}
