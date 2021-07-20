using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //get input
            Console.WriteLine("Please type in any number");
            string string_num = Console.ReadLine();
            //convert to decimal so math can be used. 
            decimal num = Convert.ToDecimal(string_num);

            //math operations
            decimal stepOne = num * 50;
            decimal stepTwo = num + 25;
            decimal stepThree = num / (decimal)12.5;
            bool stepFour = num > 50;
            decimal stepFive = num % 7;

            //print result
            Console.WriteLine(
                "Here are your operations: " +
                "\nStep 1: multiply by 50: " + stepOne +
                "\nStep 2: add 25: " + stepTwo +
                "\nStep 3: divide by 12.5: " + stepThree +
                "\nStep 4: Is it greater than 50? " + stepFour +
                "\nStep 5: Divide by 7 and get remainder: " + stepFive
                );

            Console.ReadLine();
        }
    }
}
