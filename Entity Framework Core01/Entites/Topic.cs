using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core01.Entites
{
    internal class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Relationship with Courses (One-to-Many)
         public ICollection<Course> Courses { get; set; }
    }
}

