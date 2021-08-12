using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try //try-catch block for the program
            {
                useProgram();
            }
            catch(NotOldEnoughException)
            {
                Console.WriteLine("This program is for adults 21 and up!");
                Console.ReadLine();
                return;
            }
            catch(Exception) //catch all
            {
                Console.WriteLine("Something went wrong. Please contact the System Administrator");
                Console.ReadLine();
                return;
            }
        }

        static void useProgram()
        {
            bool validAge = false;
            int age = 0;
            while (!validAge)
            {
                Console.WriteLine("Please enter your age in years");
                validAge = int.TryParse(Console.ReadLine(), out age);
                if (!validAge) Console.WriteLine("Please enter an integer only");
            }
            if (age > 21)
            {
                throw new NotOldEnoughException();
            }
            int yearBorn = DateTime.Now.Year - age;
            Console.WriteLine("You were born sometime between {0} and {1}.", yearBorn - 21, yearBorn);
            Console.ReadLine();
        }
    }

    public class NotOldEnoughException : Exception
    {
        public NotOldEnoughException()
            : base() { }
        public NotOldEnoughException(string message)
            : base(message) { }
    }
}
