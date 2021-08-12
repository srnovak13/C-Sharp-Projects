using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            const string firstName = "Steve"; //created a constant
            var lastName = "Novak"; // created a string using var
            Person friend = new Person("Tyler");  //instantiated an object of person class using a chained constructor
            Console.ReadLine(); //for setting breakpoint
        }
    }
    
    public class Person
    {
        public Person(string name) : this(name, "Student") { } //chained constructor, inherits from person, default title is "student"
        public Person(string name, string title) //main constructor
        {
            Name = name;
            Title = title;

        }
        //properties set here are assigned by constructor
        public string Name { get; set; }
        public string Title { get; set; }
    }
}
