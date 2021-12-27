using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Surname { get; set; }

        [MaxLength(150)]
        public string Image { get; set; }

        [ForeignKey("Major")]
        public int MajorId { get; set; }
        public Major Major { get; set; }

        public List<Social> socials { get; set; }
        public List<Comment> comments { get; set; }
    }
}
