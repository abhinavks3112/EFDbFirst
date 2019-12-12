using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDbFirst
{
    // Inheriting from byte since it is easy mapping between tiny int in database to byte in entity
    public enum Level : byte
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3

    }
    class Program
    {
       
        static void Main(string[] args)
        {
            var dbContext = new PlutoDbContext();
            var courses = dbContext.GetCourses();

            foreach (var course in courses)
            {
                Console.WriteLine(course.Title);
            }
        }
    }
}
