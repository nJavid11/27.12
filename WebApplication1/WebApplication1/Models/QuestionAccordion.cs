using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class QuestionAccordion
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName ="ntext")]
        public string Question { get; set; }

        [Column(TypeName = "ntext")]
        public string Answer { get; set; }
    }
}
