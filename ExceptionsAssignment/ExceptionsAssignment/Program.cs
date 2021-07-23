using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //try-catch block to check for incorrect user inputs
            try
            {
                //make list of integers
                List<int> integers = new List<int>() { 7, 11, 13, 25, 80, -5, -10, 57, 62 };

                //get input
                Console.WriteLine("Enter a number to divide a value from the list");
                double input = Convert.ToDouble(Console.ReadLine());

                if (input == 0)
                {
                    Console.WriteLine("You can't divide by zero");
                }
                else
                {
                    //print out result of the math
                    foreach (double num in integers)
                    {
                        double mathResult = num / input;
                        Console.WriteLine(mathResult);
                    }
                }
            }
            //printing out result of exception if one occurs
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("You've made it through the Try\\Catch Block!");
            Console.ReadLine();
        }
    }
}
