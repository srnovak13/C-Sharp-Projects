using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating DivideTwo class
            DivideTwo Division = new DivideTwo();

            //first method isn't void and returns an integer
            //get input from user
            Console.WriteLine("Enter an integer to divide by two.");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                int returnNum = Division.Divide(num);
                Console.WriteLine(returnNum);
            }
            else
            {
                Console.WriteLine("Input must be an even number.");
            }

            //second method is void and prints result of num/2
            Console.WriteLine("Here's the result of the void method: ");
            if (num % 2 == 0)
            {
                Division.DivideVoid(num);
            }
            else
            {
                Console.WriteLine("Input must be an even number.");
            }

            //method with out variable
            //count will be out variable
            int count;
            Console.WriteLine("Please enter a sentence: "); //get input from user
            string sentence = Console.ReadLine();
            Console.WriteLine(Division.saySomething(sentence, out count));
            Console.WriteLine(count); //write count to see the change

            //the overloaded method
            count = 0;
            Console.WriteLine("Enter an amount of times to run the loop");
            int times = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Division.saySomething(sentence, out count, times));
            Console.WriteLine(count);

            //using a static class
            Console.WriteLine("Enter an integer to divide by 3");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DivideThree.DivideByThree(num));
            Console.ReadLine();

        }
    }
}
