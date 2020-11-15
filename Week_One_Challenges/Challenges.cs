using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week_One_Challenges
{
    [TestClass]
    public class Challenges
    {
        [TestMethod]
        public void DeclareThisInitializeThat()
        {
            //declare and initialize variables that hold your first name, last name and age

            string firstName = "Danielle";
            string lastName = "Barrett";
            int myAge = 27; 


       
            //declare and initialize an array that holds a collection of at least four of your favorite books or movies
            string movie1 = "Super Troopers";
            string movie2 = "Inside Out";
            string movie3 = "Top Gun";
            string movie4 = "Batman";

            string[] stringArray = { movie1, movie2, movie3, movie4 };
        

            //Make a list to hold dates. Include on that list the current date and time.

            DateTime now = DateTime.Now;
            DateTime nineties  = new DateTime(1990, 12, 1);
            DateTime eighties = new DateTime(1980, 2, 19);
            DateTime seventies = new DateTime(1970, 5, 16);
            DateTime sixties = new DateTime(1960, 5, 8);
            List<DateTime> listofDates = new List<DateTime>();
            listofDates.Add(nineties);
            listofDates.Add(eighties);
            listofDates.Add(seventies);
            listofDates.Add(sixties);
            listofDates.Add(now);

            //Write out to the Console the values calculated by your age variable and the number 7. 
            //Use each operator we covered in Operators 

            int number = 7;

            int sum = myAge + number;
            Console.WriteLine(sum);
            int diff = myAge - number;
            Console.WriteLine(diff);
            int prod = myAge * number;
            Console.WriteLine(prod);
            int quot = myAge / number;
            Console.WriteLine(quot);
            int remainder = myAge % number;
            Console.WriteLine(remainder);

            int sleepHours = 7;

            if (sleepHours >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if ((sleepHours > 8) && (sleepHours < 10))
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if ((sleepHours > 4) && (sleepHours < 8))
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }

            string mood = "Okay";

            switch (mood)
            {
                case "Great":
                    {Console.WriteLine("I'm glad you're feeling great!"); }
                    break;

                case "Good":
                    { Console.WriteLine("Yay! You're feeling good!"); }
                    break;

                case "Okay":
                    { Console.WriteLine("We all have okay days!"); }
                    break;

                case "Bad":
                    { Console.WriteLine("Sorry to hear that!"); }
                    break;

                case ":(":
                    {
                        Console.WriteLine("Hope your day gets better!");
                    }
                    break;

                default:
                    { Console.WriteLine("You don't feel anything today"); }
                    break;
        }


    }
    }
}
