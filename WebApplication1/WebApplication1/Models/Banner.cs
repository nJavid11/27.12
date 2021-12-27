using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string UpTitle { get; set; }

        [MaxLength(50)]
        public string Title1 { get; set; }

        [MaxLength(50)]
        public string Title2 { get; set; }

        [MaxLength(50)]
        public string Title3_Opt { get; set; }

        [MaxLength(100)]
        public string Image { get; set; }

    }
}
