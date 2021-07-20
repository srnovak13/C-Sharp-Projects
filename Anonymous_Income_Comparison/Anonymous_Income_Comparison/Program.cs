using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //introduction statement
            Console.WriteLine("Anonymous Income Comparison Program");

            //obtain information

            //person 1
            Console.WriteLine("Person 1 " + "\nWhat is your hourly rate?");
            string person1Rate = Console.ReadLine();
            double person1HourlyRate = Convert.ToDouble(person1Rate);//convert to double in case of any cents made

            Console.WriteLine("What is your hours worked per week?");
            string person1Hours = Console.ReadLine();
            double person1HoursWorked = Convert.ToDouble(person1Hours);

            //person 2
            Console.WriteLine("Person 2 " + "\nWhat is your hourly rate?");
            string person2Rate = Console.ReadLine();
            double person2HourlyRate = Convert.ToDouble(person2Rate);//convert to double in case of any cents made

            Console.WriteLine("What is your hours worked per week?");
            string person2Hours = Console.ReadLine();
            double person2HoursWorked = Convert.ToDouble(person2Hours);

            //do math operations for display
            double person1Salary = person1HourlyRate * person1HoursWorked * 52;
            double person2Salary = person2HourlyRate * person2HoursWorked * 52;
            bool salaryComparison = person1Salary > person2Salary;

            //write results to console
            Console.WriteLine
                ("Annual Salary of Person 1: " + person1Salary +
                 "\nAnnual Salary of Person 2: " + person2Salary +
                 "\nDoes Person 1 make more than Person 2? " + salaryComparison);
            Console.ReadLine();

        }
    }
}
