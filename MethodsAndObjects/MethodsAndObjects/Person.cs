using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Person
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set;  }
        
        //method for saying name
        public void SayName()
        {
            string Output = $"Name: {FirstName} {LastName}";
            Console.WriteLine(Output);
        }

    }
}
