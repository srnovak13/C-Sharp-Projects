using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    public class CommonMath
    {
        /*Here are the three methods
         * "static" makes it available for use without instantiating an object
         * "public" means you need to instantiate an object first to use it
         */

        public int Squared(int num)
        {
            int result = num * num;
            return result;
        }

        public int Doubled(int num)
        {
            int result = num + num;
            return result;
        }

        public double Halved(int num)
        {
            double result = num * .5;//using a double for accuracy when dividing
            return result;
        }
    }
}
