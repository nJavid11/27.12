using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150)]
        public string Image { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Surname { get; set; }

        [MaxLength(50)]
        public string Major { get; set; }

        [Column(TypeName ="ntext")]
        public string Content { get; set; }


    }
}
