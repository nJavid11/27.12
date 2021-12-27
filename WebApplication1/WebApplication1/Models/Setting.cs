using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string AboutTitle { get; set; }

        [Column(TypeName = "ntext")]
        public string AboutContent { get; set; }

        [MaxLength(50)]
        public string DiscTitle { get; set; }

        [Column(TypeName = "ntext")]
        public string DiscContent { get; set; }

        [MaxLength(100)]
        public string DiscImage { get; set; }

        [MaxLength(50)]
        public string AboutPageTitle { get; set; }

        [Column(TypeName = "ntext")]
        public string AboutPageContent { get; set; }

        [MaxLength(50)]
        public string BlogHomeTitle { get; set; }

        [Column(TypeName = "ntext")]
        public string BlogHomeContent { get; set; }

        [MaxLength(100)]
        public string BlogHomeImage { get; set; }

        [MaxLength(50)]
        public string HomeUpTitle { get; set; }

        [MaxLength(50)]
        public string HomeTitle { get; set; }

        [Column(TypeName = "ntext")]
        public string HomeContent { get; set; }

        [MaxLength(100)]
        public string HomeImage { get; set; }


    }
}
