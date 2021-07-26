using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethodAssignment
{
    public class DefaultMath
    {
        public int Power(int num1, int num2 = 1)
        {
            if (num2 == 0)
            {
                return 1;
            }
            int result = num1;
            for (int i = 1; i < num2; i++)
            {
                result = num1;
            }
            return result;
        }
    }
}
