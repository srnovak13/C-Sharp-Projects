using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction text
            Console.WriteLine("The Tech Academy \nStudent Daily Report");

            //Questions
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            string page_string = Console.ReadLine();
            //Convert string to integer
            int page_number = Convert.ToInt32(page_string);

            Console.WriteLine("Do you need help with anything? Please answer \'True\' or \'False\'");
            string askHelp = Console.ReadLine();
            //Convert string to boolean
            bool helpAsked = Convert.ToBoolean(askHelp);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedBack = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            //Convert string to integer
            int hoursStudiedInt = Convert.ToInt32(hoursStudied);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. \nHave a great day!");
            Console.ReadLine();




        }
    }
}
