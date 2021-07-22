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
            string status = firstName + " " + lastName + " lives in " + currentCity.ToUpper();//concatenating strings
            StringBuilder newStatus = new StringBuilder(); //creating a new String Builder in order to change status easier without using up a bunch of memory
            newStatus.Append("I just moved from Oregon!");//adding new data to the string
            newStatus.Append("I enjoy living in the Teton Mountains.");
            newStatus.Append("I go mountain biking every day.");

            Console.WriteLine(newStatus);
            Console.ReadLine();
        }
    }
}
