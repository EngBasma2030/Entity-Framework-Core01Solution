using Entity_Framework_Core01.Contexts;
using Entity_Framework_Core01.Entites;
using Microsoft.EntityFrameworkCore;
using Entity_Framework_Core01.Entites;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Entity_Framework_Core01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();
            dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;

            Student stud01 = new Student()
            {
                FName = "Basma",
                LName = "Bahaa",
                Address = "Giza",
                Age = 22
            };
            Student stud02 = new Student()
            {
                FName = "Aya",
                LName = "Bahaa",
                Address = "Giza",
                Age = 25

            };

            #region insert
            //Console.WriteLine(dbContext.Entry(stud01).State);

            //dbContext.Students.Add(stud01);
            //dbContext.Set<Student>().Add(stud01);
            //dbContext.Add(stud01);
            //dbContext.Entry(stud01).State = EntityState.Added;


            //dbContext.Add(stud02);
            //Console.WriteLine("After Adding");
            //Console.WriteLine(dbContext.Entry(stud01).State);

            //dbContext.SaveChanges();
            //Console.WriteLine("After save Changes");
            //Console.WriteLine(dbContext.Entry(stud01).State);
            #endregion

            var student = dbContext.Students.SingleOrDefault(S => S.Id == 3);
            var student02 = dbContext.Students.AsNoTracking().SingleOrDefault(S => S.Id == 4);

            #region Update
            //if (student != null)
            //{
            //    student.FName = "Noha"; 
            //}

            //if (student02 != null)
            //{
            //    student02.FName = "Mona"; 
            //}
            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(student).State);
            //Console.WriteLine(dbContext.Entry(student02).State);
            #endregion

            #region Remove
            if (student != null)
            {
                //Console.WriteLine(dbContext.Entry(student).State); 

                //dbContext.Students.Remove(student);
                //dbContext.Set<Student>().Remove(student);
                //dbContext.Remove(student);
                //dbContext.Entry(student).State = EntityState.Deleted;

                //Console.WriteLine("After delete");
                //Console.WriteLine(dbContext.Entry(student).State); 

                //Console.WriteLine("After savechanges");
                //dbContext.SaveChanges();
                //Console.WriteLine(dbContext.Entry(student).State); 
            }
            #endregion

        }
    }
}
