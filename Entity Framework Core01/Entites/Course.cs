using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core01.Entites
{
    internal class Course
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Relationship with Topic (Many-to-One)
        public int? Top_ID { get; set; }
        public Topic? Topic { get; set; }

        // Relationship with Students (Many-to-Many)
         public ICollection<Stud_Course> Stud_Courses { get; set; } 

        // Relationship with Instructors (Many-to-Many)
        public ICollection<Course_Inst> Course_Instructors { get; set; } 
    }
}

