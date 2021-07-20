using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //get info
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? True or False");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt16(Console.ReadLine());

            //show calculations to see if qualified for insurance
            bool qualified = (age > 15) && (!DUI) && (tickets <= 3);

            //display result
            Console.WriteLine("Are you qualified? \n" + qualified);
            Console.ReadLine();

        }
    }
}
