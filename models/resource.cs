using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsystem3.models
{
    public enum resourcetype
    {
        video,
        presention,
        document,
        other

    }

    public class resources
    {
        [Key]
        public int id { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string name { get; set; }


        [Column(TypeName = "varchar")]
        public string url { get; set; }

        [ForeignKey("course")]
        public int course_id { get; set; }

        public course course { get; set; }
    }
}
