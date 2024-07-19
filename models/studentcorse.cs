using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsystem3.models
{
    public class studentcorse
    {
        [ForeignKey("student")]
        public int ststudent_id { get; set; }

        [ForeignKey("course")]
        public int course_id { get; set; }

        [Key]
        public string name { get; set; }





    }
}
