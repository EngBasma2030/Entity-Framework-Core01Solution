﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core01.Entites
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }

        // Relationship with Department (Many-to-One)
        public int? Dept_ID { get; set; }
        public Department? Department { get; set; }

        // Relationship with Courses (Many-to-Many)
        public ICollection<Course_Inst> Course_Instructors { get; set; } 
    }
}
