using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //write current date-time to console
            Console.WriteLine("The current date and time is {0}.", DateTime.Now);

            //get hours to add to current date-time
            Console.WriteLine("Please enter the number of hours to add to the current datetime: ");
            double hours = Convert.ToDouble(Console.ReadLine());

            //add hours to the current datetime using AddHours method
            DateTime projectedTime = DateTime.Now.AddHours(hours);

            //write to console
            Console.WriteLine($"In {hours} hours, the datetime will be {projectedTime}.");
            Console.ReadLine();
        }
    }
}
