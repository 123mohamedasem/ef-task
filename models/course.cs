using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsystem3.models
{
    public class course
    {
        [Key]
        public int course_id { get; set; }



        [MaxLength(80)]
        [Column(TypeName = "nvarchar")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar")]
        public string? description { get; set; }


        public DateTime startdate { get; set; }

        public DateTime enddate { get; set; }

        [Required]
        public decimal price { get; set; }

        public int student_id { get; set; }

        public student student { get; set; }

        public List<resources> resourcess { get; set; }

        public List<homework> homeworks { get; set; }


    }
}
