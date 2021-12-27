using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Social
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Icon { get; set; }

        [MaxLength(100)]
        public string Link { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
