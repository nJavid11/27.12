using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class LatestPost
    {
        [Key]
        public int İd { get; set; }

        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
