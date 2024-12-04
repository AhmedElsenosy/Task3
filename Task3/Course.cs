using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        //[Required]
        [MaxLength(100)]
        public string CourseName { get; set; }
        //[Required]
        public int CourseCredits { get; set; }
        public int TeacherId { get; set; }

        public Teacher teacher { get; set; }

        public List<Enrollment> enrollments { get; set; }


    }
}
