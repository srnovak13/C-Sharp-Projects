using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public class DivideTwo
    {
        //method that divides by two and returns the result
        public int Divide(int num)
        {
            int returnNum = num / 2;
            return returnNum;
        }

        //same method as above but void
        public void DivideVoid(int num)
        {
            int returnNum = num / 2;
            Console.WriteLine(returnNum);
        }

        //method that uses an out parameter
        public string saySomething(string sentence, out int count)
        {
            count = 0;
            for (int i = 0; i < 6; i++)
            {
                count++;
            }
            return sentence;
        }

        //overloaded method with an out parameter
        public string saySomething(string sentence, out int count, int times)
        {
            count = 0;
            for (int i =0; i < times; i++)
            {
                count++;
            }
            return sentence;
        }
    }
}
