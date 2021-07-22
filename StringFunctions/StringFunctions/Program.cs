using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Steve";
            string lastName = "Novak";
            string currentCity = "Jackson, WY";
            string status = firstName + " " + lastName + " lives in " + currentCity.ToUpper();
            StringBuilder newStatus = new StringBuilder();
            newStatus.Append("I just moved from Oregon!");
            newStatus.Append("I enjoy living in the Teton Mountains.");
            newStatus.Append("I go mountain biking every day.");

            Console.WriteLine(newStatus);
            Console.ReadLine();
        }
    }
}
