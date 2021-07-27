using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    class DisplaySecondInt
    {
        //void means that it doens't return anything
        public void DisplaySecond(int num1, int num2)
        {
            num1 += 1; //math done with num1
            Console.WriteLine(num2); //display num2 to console
        }

    }
}
