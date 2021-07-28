using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }
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

        public static bool operator== (Employee Person1, Employee Person2)
        {
            if (Person1.ID == Person2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator!= (Employee Person1, Employee Person2)
        {
            if (Person1.ID == Person2.ID)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
       
    }
}
