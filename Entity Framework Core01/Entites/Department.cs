using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core01.Entites
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }

        // Relationship with Head Instructor (One-to-One)
        public int? Ins_ID { get; set; }
        public Instructor? Head { get; set; }

        // Relationship with Students (One-to-Many)
        public ICollection<Student> Students { get; set; } 

        // Relationship with Instructors (One-to-Many)
        public ICollection<Instructor> Instructors { get; set; } 
    }
}
