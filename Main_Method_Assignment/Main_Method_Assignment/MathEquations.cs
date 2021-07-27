using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    public class MathEquations
    {
        //first method takes int and returns int to power of 3
        public int PowerThree(int num)
        {
            return num * num * num;
        }

        //second method takes double, returns double to power of 3, divided by 2
        public int PowerThree(decimal numDec)
        {
            int num = Convert.ToInt32(numDec);
            return (num * num * num) / 2;
        }

        //third method takes string, converts to int, takes to power of 3 and adds 2
        public int PowerThree(string numString)
        {
            int num = Convert.ToInt32(numString);
            return (num * num * num) + 2; 
        }
    }
}
