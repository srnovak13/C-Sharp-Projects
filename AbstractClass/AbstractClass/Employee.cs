using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        public void Quit()
        {
            Console.WriteLine("Do you want to quit? Y or N");
            string response = Console.ReadLine().ToLower();
            if (response == "y")
            {
                Console.WriteLine("Thank you for your time!");
            }
        }
       
    }
}
