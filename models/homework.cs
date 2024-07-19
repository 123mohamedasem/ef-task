using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsystem3.models
{
    public enum contenttype
    {
        Application,
        pdf,
        zip
    }

    public class homework
    {
        [Key]
        public int homework_id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        public string content { get; set; }

        public DateTime submissiontimr { get; set; }

        [ForeignKey("student")]
        public int student_id { get; set; }



        [ForeignKey("course")]

        public int course_id { get; set; }


        public student student { get; set; }

        public course course { get; set; }

    }
}
