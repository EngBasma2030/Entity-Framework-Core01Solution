using Entity_Framework_Core01.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core01.Contexts
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-RKP4IOQ ; Database = ITI02 ; Trusted_Connection = True ; Encrypt = False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One-to-Many: Student -> Department
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.Dept_Id)
                .OnDelete(DeleteBehavior.NoAction);

            // One-to-Many: Instructor -> Department
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.Dept_ID)
                .OnDelete(DeleteBehavior.NoAction);

            // One-to-One: Department -> Head Instructor
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Head)
                .WithOne()
                .HasForeignKey<Department>(d => d.Ins_ID)
                .OnDelete(DeleteBehavior.NoAction);

            // Many - to - Many: Student <->Course
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.stud_ID, sc.Course_ID });

            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.Stud_Courses)
                .HasForeignKey(sc => sc.stud_ID);

            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.Stud_Courses)
                .HasForeignKey(sc => sc.Course_ID);

            // Many - to - Many: Instructor <->Course
            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.inst_ID, ci.Course_ID });

            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.Course_Instructors)
                .HasForeignKey(ci => ci.inst_ID);

            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.Course_Instructors)
                .HasForeignKey(ci => ci.Course_ID);

            // One-to-Many relationship between Topic and Course
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Topic)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.Top_ID)
                .OnDelete(DeleteBehavior.NoAction);

        }

        public DbSet<Student> Students { get; set; }
         public DbSet<Course> Courses { get; set; }
         public DbSet<Course_Inst> Course_Insts { get; set; }
         public DbSet<Department> Departments { get; set; }
         public DbSet<Instructor> Instructors { get; set; }
         public DbSet<Stud_Course> Stud_Courses { get; set; }
         public DbSet<Topic> Topics { get; set; }
    }
}
