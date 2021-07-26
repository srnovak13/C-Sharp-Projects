using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //get input from user
            Console.WriteLine("Please enter a digit that you would like to do math with");
            int input = Convert.ToInt32(Console.ReadLine());

            //use methods created in CommonMath class
            CommonMath doMath = new CommonMath();
            int square = doMath.Squared(input);
            int doubled = doMath.Doubled(input);
            double half = doMath.Halved(input);

            //print to console
            Console.WriteLine(
                "Squared: " + square + 
                "\nDoubled: " + doubled +
                "\nHalved: " + half
                );
            Console.ReadLine();



        }
    }
}
