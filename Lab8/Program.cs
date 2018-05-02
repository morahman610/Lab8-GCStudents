using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gradebook
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Welcome());

            while (true)
            {

                string[] names =
                    {
                "Mohammed",
                "Diana",
                "Rebekah",
                "Nadim",
                "Mubin",
                "Ragib",
                "Doha",
                "Amanda",
                "Theresa",
                "Bodrul",
                "Mumen",
                "Zakir",
                "Emran",
                "Fatima",
                "Aamina",
                "Linda",
                "Sabrina",
                "Syed",
                "Abdul",
                "Iqbal",
                "Musa"
                };

                string[] hometown =
                {
                "Detroit",
                "Hamtramck",
                "New York",
                "The Bronx",
                "Canton",
                "Troy",
                "Warren",
                "Chicago",
                "Oakland",
                "Austin",
                "Talahassee",
                "Atlanta",
                "San Diego",
                "Sylhet",
                "Dearborn",
                "New Orleans",
                "Toledo",
                "Denmark",
                "Tampa bay",
                "Queens",
                "Grand Rapids"
                };

                String[] food =
                {
                "Chicken 65",
                "Shrimp Fried Rice",
                "Chicken Noodle Soup",
                "Biryani",
                "Butter Chicken",
                "Chicken Tikka Masala",
                "Lamb Hanif",
                "Galaba",
                "Chips",
                "Ice cream",
                "Tandoori",
                "Shwarma",
                "Volcano burgur",
                "Sal's Fries",
                "Nacho Burger",
                "Fies",
                "Salad",
                "Curry",
                "Daal",
                "Shutki"
                 };


                int student = AskForUserInput();

                student--;





                TakeResponses(names[student], hometown[student], food[student]);

                Console.WriteLine("Would you like to learn about another student? Press Y to continue or press any other key to quit");
                string DoAgain = Console.ReadLine().ToLower();
                if (!(DoAgain == "y"))
                {
                    return;
                }

            }





           // PickStudent();
        }



        static void TakeResponses(string name, string hometown, string food)
        {
            Console.WriteLine($"You've entered: {name}.");
            while (true)
            {
                Console.WriteLine($"What would you like to konw about {name}? (enter 'hometown' or 'favorite food'");
                string hometownOrFood = Console.ReadLine().ToLower();

                if (hometownOrFood == "hometown")
                {
                    Console.WriteLine($"{name}'s hometown is {hometown}. If you would like to know this students favorite food than enter 'food'.");
                    string LearnMore = Console.ReadLine();
                    if (LearnMore == "food")
                    {
                        Console.WriteLine($"{name}'s favorite food is {food}");
                        return;
                    }
                    else
                    {
                        return;
                    }

                }

                else if (hometownOrFood == "favorite food")
                {
                    Console.WriteLine($"{name}'s favorite food is {food}.If you would like to know this students favorite food than enter 'food'.");
                    string LearnMore = Console.ReadLine();
                    if (LearnMore == "food")
                    {
                        Console.WriteLine($"{name}'s favorite food is {food}");
                        return;
                    }
                    else
                    {
                        return;
                    }
                }

                else
                {
                    Console.WriteLine("That was not a valid input. Please try again by pressing any key or press 'q' to quit.");
                    string TryAgain = Console.ReadLine();
                    return;

                }
            }
        }

        static void MoreInfo(string MoreInfo)
        {

        }

        static string Welcome()
        {
            string welcome = "Welcome to  the C# Meridian Bootcamp. Which student would you like to learn more about?" +
                "(Enter a number 1-20)";
            return welcome;
        }

        static int AskForUserInput()
        {

            while (true)
            {
                string UserInput = Console.ReadLine();
                if (!(int.TryParse(UserInput, out int student)) || student < 1 || student > 20)
                {
                    Console.WriteLine("Invalid Input. You did not enter an integer between 1-20");
                }

                else
                {
                    return student;
                } 
                }

        }
        /* static string PickStudent()
         {
             string UsersStudent = Console.ReadLine();

             try
             {
                 var StudentName = int.Parse(UsersStudent);
             }
             catch (FormatException)
             {
                 Console.WriteLine($"{UsersStudent} is not an integer. Please enter an integer.");

             }

         } */


    }
}