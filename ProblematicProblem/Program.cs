using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ProblematicProblem
{
    public class Program
    {

        static void Main(string[] args)
        {

            var rng = new Random();
            bool cont = true;
            List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            string answer = (Console.ReadLine());

            if (answer == "yes")
            {
                cont = true;
            }
            else if (answer == "YES")
            {
                cont = true;
            }
            else if (answer == "Yes")
            {
                cont = true;
            }
            else
            {
                cont = false;
            }

            if(cont == false)
            {
                Console.WriteLine("ThankYou For Your Time!");
                System.Environment.Exit(0);
            }

            Console.WriteLine();

            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("What is your age? ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            string seeList1 = (Console.ReadLine());
            string seeList = seeList1.ToLower();

            if (seeList == "sure")
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }
                foreach (var activity in activities)
                {
                    Console.Write($"{activity}, ");
                    Thread.Sleep(250);
                }

                bool addToList = true;
                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                string addToList1 = Console.ReadLine();
                Console.WriteLine();
                string addList = addToList1.ToLower();

                if (addList == "yes")
                {
                    addToList = true;
                }
                else
                {
                    addToList = false;
                }



                while (addToList == true)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();

                    activities.Add(userAddition);

                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }

                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    string addMore = Console.ReadLine();
                    string addMORE = addMore.ToLower();


                    if (addMORE == "yes")
                    {
                        Console.Write("What would you like to add? ");
                        userAddition = Console.ReadLine();

                        activities.Add(userAddition);

                        foreach (string activity in activities)
                        {
                            Console.Write($"{activity} ");
                            Thread.Sleep(250);
                        }
                    }
                    else
                    {
                        
                       
                            Console.WriteLine("ThankYou For Your Time!");
                            System.Environment.Exit(0);
                        
                    }
                }
            }

           
            while (cont == true)
            {
                Console.Write("Connecting to the database");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                Console.Write("Choosing your random activity");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                int randomNumber = rng.Next(activities.Count);

                string randomActivity = activities[randomNumber];

                if (userAge > 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");

                    activities.Remove(randomActivity);

                    randomNumber = rng.Next(activities.Count);

                    randomActivity = activities[randomNumber];
                }

                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                answer = Console.ReadLine();
                if ( answer == "keep")
                {
                  
                        Console.WriteLine("ThankYou For Your Time!");
                        System.Environment.Exit(0);
                }
                else if ( answer == "Keep")
                { 
                        Console.WriteLine("ThankYou For Your Time!");
                        System.Environment.Exit(0);
                  }

                
                


            }
        }
    }
}
