using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array of strings
            string[] stringArray = { "Oklahoma", "New York", "Kansas", "Nevada", "Oregon" };
            //ask for input from user 
            Console.WriteLine("Please input a suffix of either \"City\" or \"State\"");
            string suffix = Console.ReadLine();
            //append user input to end of each string
            for (int j = 0; j < stringArray.Length; j++)
            {
                stringArray[j] = stringArray[j] + " " + suffix;
            }
            //print new strings from array to console
            foreach (string city in stringArray)
            {
                Console.WriteLine(city);
            }
            Console.ReadLine();

            //first created an infinite loop without adding j++, then added it back to break the loop
            int i = 0;
            while (i <= 5)
            {
                Console.WriteLine("No longer an infinite loop!");
                i++;
            }
            Console.ReadLine();

            //create an array of integers
            int[] int_array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //this is a random loop that uses <
            for (int m = 0; m < int_array.Length; m++ )
            {
                if (int_array[m] == 7)
                {
                    Console.WriteLine("Lucky number 7!");
                }
                else if (m == int_array.Length-1)
                {
                    Console.WriteLine("This isn't a lucky number.");
                }
            }

            //setting up while loop and getting input from user how many times it should run
            int p = 1;
            Console.WriteLine("\n Please enter the amount of times you'd like the loop to run");
            int timesToRun = Convert.ToInt32(Console.ReadLine());
            //this uses <= to make the loop run as many times as the user inputs
            while (p <= timesToRun)
            {
                Console.WriteLine("Iteration: " + p);
                p++;
            }
            Console.ReadLine();

            //a list of strings
            List<string> string_list = new List<string>() { "Joey", "Chandler", "Ross", "Monica", "Phoebe", "Rachel" };
            Console.WriteLine("Please enter the name you'd like to search for:");
            string chosenName = Console.ReadLine();
            //this loop searches for the input from user and breaks on first instance it finds
            for (int f = 0; f < string_list.Count; f++)
            {
                if(string_list[f] == chosenName)
                {
                    Console.WriteLine("The index of " + chosenName + " is " + f);
                    break;
                }
                else if (f == string_list.Count-1)
                {
                    Console.WriteLine("The name you entered isn't on the list.");
                }
                
            }
            //instantiate string list with some identical strings
            List<string> sameList = new List<string>() { "Cat", "Dog", "Hamster", "Dog", "Cat", "Snake", "Parrot" };
            Console.WriteLine("Please enter your favorite pet:");
            string favPet = Console.ReadLine();

            bool exists = false;//necessary to not run else if statement
            for (int q = 0; q < sameList.Count; q++)
            {
                if (sameList[q] == favPet)
                {
                    Console.WriteLine("The index of " + favPet + " is " + q);
                    exists = true;//change boolean to know we've found at least one match
                }
                else if (q == sameList.Count-1 && !exists)
                {
                    Console.WriteLine("That pet isn't in the list");
                }
            }
            Console.ReadLine();

            List<string> already_in_list = new List<string>();//list to store elements that are the same
            foreach (string pet in sameList)
            {
                if (already_in_list.Contains(pet))
                {
                    Console.WriteLine("\n The pet at this index is " + pet +
                                      "\n Appeared in this list: Yes");
                }
                else
                {
                    Console.WriteLine("\n The pet at this index is " + pet +
                                      " \n Appeared in this list: No");
                    already_in_list.Add(pet);
                }
            }
            Console.ReadLine();



        }
    }
}
