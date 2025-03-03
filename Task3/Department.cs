﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        //[Required]
        [MaxLength(100)]
        public string DepartmentName { get; set; }

        public List<Teacher> teachers { get; set; }
    }
}
