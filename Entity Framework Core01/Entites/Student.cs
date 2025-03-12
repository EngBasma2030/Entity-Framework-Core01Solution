using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core01.Entites
{
    internal class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //[Required]
        //[Column(TypeName = "varchar")]
        //[MaxLength(50)]
        //[StringLength(50, MinimumLength = 10)]
        public string FName { get; set; }
        //[Required]
        //[Column(TypeName = "varchar")]
        //[MaxLength(50)]
        //[StringLength(50, MinimumLength = 10)]
        public string LName { get; set; }
        public string Address { get; set; }

        [Range(21, 60)]
        public int Age { get; set; }

        // Relationship with Department (Many-to-One)
        public int? Dept_Id { get; set; }
        public Department? Department { get; set; }

        // Relationship with Courses (Many-to-Many)
         public ICollection<Stud_Course> Stud_Courses { get; set; } 


    }
}
