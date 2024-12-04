using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Grade
    {
        [Key]
        public int GradeID { get; set; }
        //[Required]
        [MaxLength(100)]
        public string GradeName { get; set; }

        public Enrollment enrollment { get; set; }

        
    }
}
