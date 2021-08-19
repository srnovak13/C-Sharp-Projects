using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                //create and save new student
                Console.WriteLine("Student's First Name: ");
                var firstName = Console.ReadLine();
                Console.WriteLine("Student's Last Name: ");
                var lastName = Console.ReadLine();

                var student = new Student { FirstName = firstName, LastName = lastName };
                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }

    }

    
}
