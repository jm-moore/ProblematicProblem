using System;
using System.Collections.Generic;
using System.Threading;

public class ProblematicProblem
{
    public class Program
    {
        Random rng;
       // static bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        static void Main(string[] args)
{
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            string cont1 = Console.ReadLine().ToLower();
            bool cont = (cont1 == "yes") ? true : false;
            if (cont == false)
            {
                Console.WriteLine("Have a great day!");
                return;
            }
            Console.WriteLine();
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            string seeList1 = Console.ReadLine().ToLower();
            bool seeList = (seeList1 == "sure") ? true : false;

    if (seeList)
    {
        foreach (string activity in activities)
        {
            Console.Write($"{activity} ");
            Thread.Sleep(2);
        }
        Console.WriteLine();
        Console.Write("Would you like to add any activities before we generate one? yes/no: ");
        string addToList1 = Console.ReadLine().ToLower();
        bool addToList = (addToList1 == "yes") ? true : false;
        Console.WriteLine();
        while (addToList)
        {
            Console.Write("What would you like to add? ");
            string userAddition = Console.ReadLine();
            activities.Add(userAddition);
            foreach (string activity in activities)
            {
                Console.Write($"{activity} ");
                Thread.Sleep(2);
            }
            Console.WriteLine();
            Console.WriteLine("Would you like to add more? yes/no: ");
            string addtoList3 = Console.ReadLine().ToLower();
            bool addToList2 = (addtoList3 == "yes") ? true : false;
            if (addToList2 == false)
                    {
                        return;
                    }
        } 
        
    }

            while (cont)
    {
        Console.Write("Connecting to the database");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(". ");
            Thread.Sleep(5);
        }
                Console.WriteLine();
                Console.Write("Choosing your random activity");
        for (int i = 0; i < 9; i++)
        {
            Console.Write(". ");
            Thread.Sleep(5);
        }
        Console.WriteLine();
        Random rng = new Random();
        int randomNumber = rng.Next(activities.Count);
        string randomActivity = activities[randomNumber];
              if (userAge < 21 && randomActivity == "Wine Tasting")
        {
            Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
            Console.WriteLine("Pick something else!");
            activities.Remove(randomActivity);
        }
                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                Console.WriteLine();
                string cont4 = Console.ReadLine().ToLower();
                bool cont3 = (cont4 == "redo") ? true : false;
                if (cont3)
                {
                    Console.Write("Connecting to the database");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(5);
                    }
                    Console.WriteLine();
                    Console.Write("Choosing your random activity");
                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(5);
                    }
                    Console.WriteLine();
                    Random rng2 = new Random();
                    int randomNumber2 = rng.Next(activities.Count);
                    string randomActivity2 = activities[randomNumber];
                    if (userAge < 21 && randomActivity == "Wine Tasting")
                    {
                        Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity2}");
                        Console.WriteLine("Pick something else!");
                        activities.Remove(randomActivity2);
                    }
                    Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity2}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                    Console.WriteLine();
                }
                else Console.WriteLine("Have a great day!"); return;
    }
}
    }
}