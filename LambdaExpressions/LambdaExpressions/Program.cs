using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>(); //initiating list
            //adding ten new employees
            Employees.Add(new Employee() { FirstName = "Steve", LastName = "Novak", ID = 1 });
            Employees.Add(new Employee() { FirstName = "Joe", LastName = "Dirt", ID = 2 });
            Employees.Add(new Employee() { FirstName = "Joe", LastName = "Biden", ID = 46 });
            Employees.Add(new Employee() { FirstName = "Hannibal", LastName = "Barca", ID = 3 });
            Employees.Add(new Employee() { FirstName = "Albert", LastName = "Einstein", ID = 4 });
            Employees.Add(new Employee() { FirstName = "Edgar", LastName = "Poe", ID = 5 });
            Employees.Add(new Employee() { FirstName = "Jack", LastName = "Kerouac", ID = 6 });
            Employees.Add(new Employee() { FirstName = "Stephen", LastName = "King", ID = 666 });
            Employees.Add(new Employee() { FirstName = "Mark", LastName = "Kanning", ID = 7 });
            Employees.Add(new Employee() { FirstName = "Amanda", LastName = "Hamilton", ID = 8 });

            List<Employee> joeList = new List<Employee>(); //new list for foreach loop
            foreach (Employee person in Employees)
            {
                if (person.FirstName == "Joe")
                {
                    joeList.Add(person);
                }
            }
            //below is a lambda expression that does the same thing as the foreach loop
            List<Employee> joeLambda = Employees.Where(person => person.FirstName == "Joe").ToList();

            //this pulls out people whose ID is greater than 5
            List<Employee> IDoverFive = Employees.Where(person => person.ID > 5).ToList();

            //print out each to console
            Console.WriteLine("Here's the list from the foreach loop: ");
            foreach (Employee item in joeList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }

            Console.WriteLine("\n Here is the list from the lambda function: ");
            foreach (Employee item in joeLambda)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }

            Console.WriteLine("\n Here's the list from the lambda function where IDs are greater than five: ");
            foreach (Employee item in IDoverFive)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
            Console.ReadLine();
        }
    }
}
