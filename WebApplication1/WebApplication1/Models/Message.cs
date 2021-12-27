using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Subject { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }
    }
}
