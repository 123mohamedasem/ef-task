using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsystem3.models
{
    public class student
    {
        [Key]
        public int student_id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string name { get; set; }

        [MaxLength(10, ErrorMessage = "phone number must be 10 characters or less"), MinLength(5)]
        public string phonenumber { get; set; }

        public DateTime registeredon { get; set; }

        public DateTime? birthday { get; set; }

        public List<course> courses { get; set; }

        public List<homework> homeworks { get; set; }

        public int course_id { get; set; }



    }
}
