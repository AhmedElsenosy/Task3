﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        //[Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        //[Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        //[Required]
        [EmailAddress]
        public string Email { get; set; }

        public List<Enrollment> enrollments { get; set; }

    }
}
