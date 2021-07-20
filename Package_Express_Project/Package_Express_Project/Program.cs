using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Express_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro text
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //get weight
            Console.WriteLine("What is the weight of the package?");
            double weight = Convert.ToDouble(Console.ReadLine());

            //check weight against requirements
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped by Package Express. Have a good day!");
                Console.ReadLine();
            }
            else
            {
                //get dimensions
                Console.WriteLine("What is the package width?");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the package height?");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                double length = Convert.ToDouble(Console.ReadLine());

                //check size against requirements
                if(width+height+length > 50)
                {
                    Console.WriteLine("Package too big to be shipped by Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    //calculate quote and display to user
                    double quote = (height * width * length * weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: " +
                                      "\n$" + quote);
                    Console.ReadLine();
                }
            }
        }
    }
}
