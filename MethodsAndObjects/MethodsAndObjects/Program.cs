using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize test employee
            Employee Test = new Employee() { FirstName = "Sample", LastName = "Student" };
            Test.SayName();
            Console.ReadLine();
            

            
        }
    }
}
