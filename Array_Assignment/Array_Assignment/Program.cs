using System;
using System.Collections.Generic;




    class Program
    {
        static void Main(string[] args)
        {
        //declare arrays and lists below
        string[] cities = { "Dublin", "Paris", "Rome", "Los Angeles", "New York", "London" };
        int[] years = { 1980, 1998, 2000, 2012, 2020, 2021 };
        List<string> favCities = new List<string>();
        favCities.Add("Jackson");
        favCities.Add("Seattle");
        favCities.Add("Boston");
        favCities.Add("Montreal");
        favCities.Add("Toronto");

        int favCities_maxIndex = favCities.Count - 1;

        //Console App

        //get input for array of names
        Console.WriteLine("Hey there! We have an array of city names, an array of integers, and a list of my favorite cities" +
            "\n Let's start with the array of names. Please select a number index between 0 and 5");
        int citiesChoice = Convert.ToInt32(Console.ReadLine());

        //the if statement will check to see if the index number entered is out of range
        //the else if statement will return the value at the index entered
        
        if(citiesChoice > cities.Length-1 || citiesChoice < 0)
        {
            Console.WriteLine("You have chosen an index number that doesn't exist.");
            Console.ReadLine();
        }
        else if(citiesChoice <= cities.Length-1 && citiesChoice >= 0)
        {
            Console.WriteLine("The index number you have chosen is " + cities[citiesChoice]);
        }

        Console.WriteLine("Now let's choose an index number to display a year in an array of years." +
            "\n Please choose an index number between 0 and 5");
        int yearsChoice = Convert.ToInt32(Console.ReadLine());

        if(yearsChoice > years.Length-1 || yearsChoice < 0)
        {
            Console.WriteLine("You have chosen an index number that doesn't exist.");
            Console.ReadLine();
        }
        else if(yearsChoice <= years.Length-1 && yearsChoice >= 0)
        {
            Console.WriteLine("The index number you have chosen is " + years[yearsChoice]);
        }
        Console.WriteLine("Now, let's choose an index number to see one of my favorite cities" +
            "\n Please pick a number between 0 and " + favCities_maxIndex);
        int favCities_choice = Convert.ToInt32(Console.ReadLine());

        if(favCities_choice > favCities_maxIndex || favCities_choice < 0)
        {
            Console.WriteLine("You have chosen an index number that doesn't exist.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("The index number you have chosen corresponds to " + favCities[favCities_choice]);
            Console.ReadLine();
        }




        }
    }

