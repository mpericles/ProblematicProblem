using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    class Program 
    {
       
        //Random rng;
        //bool cont = true;
        static List<string> activities = new List<string> { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        static void Main(string[] args)
        {
            Random rng = new Random();
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            //string answer = Console.ReadLine();
            //Use of Tenary instead
            bool cont = Console.ReadLine() == "yes" ? true : false;
            //bool cont = Console.ReadLine() == "yes"; // This is also valid
            //bool cont;
            //if(answer == "yes"  || answer == "sure")
            //{
            //    cont = true;
            //}
            //else
            //{
            //    cont = false;
            //}

            //We need to account for all answers. It is possible that they don't want to play the game.
            //Also need to account for all case and all variations in the answers like YES, y, Yes, yES,NO, nO, No, N.
            //will submit for now. need to catch up on studying :-)

            if (cont == true)
            {
                Console.WriteLine();
                Console.Write("We are going to need your information first! What is your name? ");
                string userName = Console.ReadLine();
                //Console.ReadLine();

                //Console.WriteLine();
                Console.Write("What is your age? ");
                //int userAge = Console.ReadLine();
                int userAge = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
                Console.WriteLine();
                //bool seeList = bool.Parse(Console.ReadLine());
                //Use of Tenary instead
                bool seeList = Console.ReadLine() == "sure"  ? true : false;
                //bool seeList;
                //string answer1 = Console.ReadLine();
                //if (answer1 == "Sure")
                //{
                //    seeList = true;
                //}
                //else
                //{
                //    seeList = false;
                //}
                if (seeList)
                {
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        //Thread.Sleep(250);
                    }
                    Console.WriteLine();
                    Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                    //bool addToList = bool.Parse(Console.ReadLine());
                    bool addToList = Console.ReadLine() == "yes" ? true : false;
                    //bool addToList;
                    //var answer2 = Console.ReadLine();
                    //if (answer2 == "Yes")
                    //{
                    //    addToList = true;
                    //}
                    //else
                    //{
                    //    addToList = false;
                    //}
                    Console.WriteLine();

                    while (addToList)
                    {
                        Console.Write("What would you like to add? ");
                        string userAddition = Console.ReadLine();
                        activities.Add(userAddition);
                        foreach (string activity in activities)
                        {
                            Console.Write($"{activity} ");
                            //Thread.Sleep(250);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Would you like to add more? yes/no: ");
                        addToList = Console.ReadLine() == "yes" ? true : false;
                        //string addToList = bool.Parse(Console.ReadLine());
                    }
                }

                while (cont)
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
                    //int randomNumber = rng.Next(activities.Count);
                    int randomNumber = rng.Next(activities.Count);
                    //int randomNumber = rng.Next(activities.Count);
                    string randomActivity = activities[randomNumber];

                    if (userAge < 21 && randomActivity == "Wine Tasting")
                    {
                        //string randomNumber1 = rng.Next(activities.Count);
                        //string randomActivity = activities[randomNumber];
                        Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                        Console.WriteLine("Pick something else!");
                        activities.Remove(randomActivity);

                    }
                    Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                    Console.WriteLine();
                    //bool cont2;
                    //var answer3 = Console.ReadLine().ToLower();
                    //if (answer3 == "keep") // Always account for any case
                    //        {
                    //            cont2 = true;
                    //        }
                    //else
                    //{
                    //  cont2 = false;
                    //}
                    //act on cont2 true then stop and false run again
                    //bool cont1 = bool.Parse(Console.ReadLine());
                    cont = Console.ReadLine() == "redo" ? true : false;
                }
            }
            else
            {
                Console.WriteLine("Ah Ok. You started this program in error. You don't want to play the game");
                Console.WriteLine();
                Console.WriteLine("Just in case you said no in error.");
                Console.WriteLine("I will share the list of activities with you and you can choose to play again by entering the game again");
                Console.WriteLine();
                Console.WriteLine("here is the list of Activities");
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    //Thread.Sleep(250);
                }
                Console.WriteLine();
            }
            
        }
    }
}

