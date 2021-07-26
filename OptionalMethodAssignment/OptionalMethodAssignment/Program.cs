using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DefaultMath powerOf = new DefaultMath();
            Console.WriteLine("Please enter two integers. The first one will be taken to the power of the second." +
                              "\n If you only enter one integer, it will be taken to the power of one.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int result;
            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                result = powerOf.Power(num1, num2);
            }

            catch (Exception)
            {
                result = powerOf.Power(num1);
            }
            Console.WriteLine("The result is: " + result);
            Console.ReadLine();

        }
    }
}
