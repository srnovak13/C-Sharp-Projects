using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            DisplaySecondInt displayInt = new DisplaySecondInt();

            //calling the method twice
            displayInt.DisplaySecond(2, 4); //parameters passed in with nums only
            displayInt.DisplaySecond(num1: 3, num2: 5); //parameters passed with names assigned for readibility
            Console.ReadLine();

        }
    }
}
