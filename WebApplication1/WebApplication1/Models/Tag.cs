using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(25)]
        public string Name { get; set; }

        public List<BlogToTag> blogToTags { get; set; }
    }
}
