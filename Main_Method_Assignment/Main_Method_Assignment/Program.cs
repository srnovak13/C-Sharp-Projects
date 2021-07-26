using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            MathEquations doMath = new MathEquations();

            //using three methods from MathEquations class
            int powerOfThree = doMath.PowerThree(3);
            double decimalMath = doMath.PowerThree(3.14);
            int stringConvert = doMath.PowerThree("5");

            //print out to console
            Console.WriteLine("Three to the power of three: " + powerOfThree);
            Console.WriteLine("3.14 to the power of three divided by 2: " + decimalMath);
            Console.WriteLine("\"5\" converted to a string and given power of three plus two: " + stringConvert);
            Console.ReadLine();
        }
    }
}
