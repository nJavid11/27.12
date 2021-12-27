using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Support
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Icon { get; set; }

        [MaxLength(20)]
        public string Uptitle { get; set; }

        [MaxLength(20)]
        public string Title { get; set; }

    }
}
