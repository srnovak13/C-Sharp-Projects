using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //get initial value
            Console.WriteLine("What is the best state?");
            string state = Console.ReadLine();

            //declare while loop for response until Vermont is picked
            while(state != "Vermont")
            {
                Console.WriteLine("Everything is better than that state! Try again!");
                state = Console.ReadLine();
            }
            //the while loop is broken once Vermont is picked
            Console.WriteLine("Congratulations! Vermont is the best state!");

            //declare value for breaking while loop
            bool go = false;
            //do this stuff untl while loop breaks

            do
            {
                Console.WriteLine("What is the best band?");
                string bestBand = Console.ReadLine();//get response
                switch (bestBand)//give prepared responses
                {
                    case "Beatles":
                        Console.WriteLine("Hey Jude! They're good...but not the best. Try again.");
                        break;
                    case "Rolling Stones":
                        Console.WriteLine("Roll on out of here with that! Try again.");
                        break;
                    case "Alice In Chains":
                        Console.WriteLine("You obviously have great taste. Absolutely correct!");
                        Console.ReadLine();
                        go = true; //breaking the while loop so it doesn't run forever
                        break;
                    default:
                        Console.WriteLine("You know a lot of bands, but not the right ones!");
                        break;


                }
            }
            while (!go);
        }
    }
}
