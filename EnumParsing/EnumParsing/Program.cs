using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumParsing
{
    class Program
    {
        static void Main()
        {
            //get input from user
            Console.WriteLine("Please enter the current day of the week: ");
            string TodaysDate = Console.ReadLine();

            //using parse() method
            try
            {
                DaysOfWeek Today = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), TodaysDate);//parses enum and turns input into an enum variable
                Console.WriteLine(Today);
                Console.WriteLine((int)Today);
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Main(); //recursive call to give user another chance
            }
        }
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
    
}
