﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }
        public int StudentId {  get; set; }
        public int CourseId { get; set; }
        public int GradeId {  get; set; }

        public Student student { get; set; }
        public Course course { get; set; }
        public Grade grade { get; set; }


    }
}
