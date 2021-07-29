using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number() { Amount = 104.235m };
            Console.WriteLine($"The number assigned to our struct number is: {num.Amount}");
            Console.ReadLine();
        }
    }
}
