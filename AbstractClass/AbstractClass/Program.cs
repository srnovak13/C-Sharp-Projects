using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee first = new Employee() { FirstName = "Steve", LastName = "Novak", ID = 112580 };
            Employee second = new Employee() { FirstName = "Steve", LastName = "Novak", ID = 92757 };
            Console.WriteLine(first == second);
            Console.WriteLine(first != second);
            Console.ReadLine();
            //Employee Test = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Test.SayName();
            //Console.ReadLine();

            //IQuittable IQuit = new Employee() { FirstName = "Norman", LastName = "Bates" };
            //IQuit.Quit();
        }

        

    }
}
