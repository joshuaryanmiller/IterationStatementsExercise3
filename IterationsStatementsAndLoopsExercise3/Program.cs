using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace IterationsStatementsAndLoopsExercise3
{
    internal class Program
    {
        public static void WriteNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                var countdown = new List<int>();
                countdown.Add(i);
                countdown.ForEach(i => Console.Write("{0} ", i));
            }
        }
        public static void TripleNumbers()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                var triples = new List<int>();
                triples.Add(i);
                triples.ForEach(i => Console.Write("{0} ", i));
            }
        }
        public static void CheckIfEqual()
        {
            Console.WriteLine("What is your first number?");
            string input = Console.ReadLine();
            int x;
            while (!Int32.TryParse(input, out x))
            {
                Console.WriteLine("Please type a number.");
                input = Console.ReadLine();
                Int32.TryParse(input, out x);
            }
            Console.WriteLine("What is your second number?");
            input = Console.ReadLine();
            int y;
            while (!Int32.TryParse(input, out y))
            {
                Console.WriteLine("Please type a number.");
                input = Console.ReadLine();
                Int32.TryParse(input, out y);
            }
            if (x == y)
            {
                Console.WriteLine($"{x} equals {y}.");
            }
            else if ( x > y)
            {
                Console.WriteLine($"{x} is greater than {y}.");
            }
            else
            {
                Console.WriteLine($"{x} is less than {y}.");
            }
        }
        public static void EvenOrOdd()
        {
            Console.WriteLine("What number?");
            string input = Console.ReadLine();
            int x;
            while (!Int32.TryParse(input, out x))
            {
                Console.WriteLine("Please type a number.");
                input = Console.ReadLine();
                Int32.TryParse(input, out x);
            }
            if (x%2 == 0)
            {
                Console.WriteLine($"{x} is an even number.");
            }
            else
            {
                Console.WriteLine($"{x} is an odd number.");
            }
        }
        public static void PositiveOrNegative()
        {
            Console.WriteLine("What number?");
            string input = Console.ReadLine();
            int x;
            while (!Int32.TryParse(input, out x))
            {
                Console.WriteLine("Please type a number.");
                input = Console.ReadLine();
                Int32.TryParse(input, out x);
            }
            if (x > 0)
            {
                Console.WriteLine($"{x} is a positive number.");
            }
            else if (x == 0)
            {
                Console.WriteLine("0 is neither positive nor negative.");
            }
            else
            {
                Console.WriteLine($"{x} is a negative number.");
            }
        }
        public static void VotingAge()
        {
            Console.WriteLine("What's your age?");
            string input = Console.ReadLine();
            int x;
            while (!Int32.TryParse(input, out x))
            {
                Console.WriteLine("Please type a number.");
                input = Console.ReadLine();
                Int32.TryParse(input, out x);
            }
            if (x >= 18)
            {
                Console.WriteLine($"You may vote.");
            }
            else if (x >= 15)
            {
                Console.WriteLine("You may not yet vote, but soon you will be able to!");
            }
            else if (x <= 0)
            {
                Console.WriteLine("You are nonexistent.");
            }
            else if (x < 5)
            {
                Console.WriteLine("Are you sure you can even read this?");
            }
            else if (x < 15)
            {
                Console.WriteLine("You don't need to think about voting. Go out and have some fun!");
            }
        }
        public static void BetweenTheTens()
        {
            Console.WriteLine("What number?");
            string input = Console.ReadLine();
            int x;
            while (!Int32.TryParse(input, out x))
            {
                Console.WriteLine("Please type a number.");
                input = Console.ReadLine();
                Int32.TryParse(input, out x);
            }
            if (x > -10 && x < 10)
            {
                Console.WriteLine($"{x} is between -10 and 10.");
            }
            else
            {
                Console.WriteLine($"{x} is not between -10 and 10.");
            }
        }
        public static void OneThroughTwelveMultiplicationTable()
        {
            Console.WriteLine("What number?");
            string input = Console.ReadLine();
            int x;
            while (!Int32.TryParse(input, out x))
            {
                Console.WriteLine("Please type a number.");
                input = Console.ReadLine();
                Int32.TryParse(input, out x);
            }
            var product1 = x * 1; var product2 = x * 2; var product3 = x * 3;
            var product4 = x * 4; var product5 = x * 5; var product6 = x * 6;
            var product7 = x * 7; var product8 = x * 8; var product9 = x * 9;
            var product10 = x * 10; var product11 = x * 11; var product12 = x * 12;
            Console.WriteLine
                ($"\n" +
                 $"\n" +
                 $"\n           {x} times table from 1 to 12" +
                 $"\n" +
                 $"\n {product1}   {product2}   {product3}   {product4}   {product5}   {product6}" +
                 $"   {product7}   {product8}   {product9}   {product10}   {product11}   {product12}");
        }
        static void Main (string[] args)
        {
            //Driver code for 1,000 to -1,000 with yes or no input
            Console.WriteLine($"Shall I print all numbers from 1,000 to -1,000?");
            Console.WriteLine("Yes or No?");
            var answer = Console.ReadLine().ToLower();
            while (answer != "yes")
            {
                if (answer == "no")
                {
                    Console.WriteLine("That's unfortunate...");
                    break;
                }
                else
                {
                    Console.WriteLine("Yes or No?");
                    answer = Console.ReadLine().ToLower();
                }
            }
            if (answer == ("yes"))
            {
                WriteNumbers();
            }
            //Driver code for 3 to 999 with yes or no input
            Console.WriteLine($"\n\nShall I now proceed to print all numbers from 3 to 999?");
            Console.WriteLine("Yes or No?");
            answer = Console.ReadLine().ToLower();
            while (answer != "yes")
            {
                if (answer == "no")
                {
                    Console.WriteLine("That's unfortunate...");
                    break;
                }
                else
                {
                    Console.WriteLine("Yes or No?");
                    answer = Console.ReadLine().ToLower();
                }
            }
            if (answer == ("yes"))
            {
                TripleNumbers();
            }
            //Driver code to compare two numbers with yes or no input
            Console.WriteLine("\n\nWould you like to check if two numbers chosen by you are equal?");
            Console.WriteLine("Yes or No?");
            answer = Console.ReadLine().ToLower();
            while (answer != "yes")
            {
                if (answer == "no")
                {
                    Console.WriteLine("That's unfortunate...");
                    break;
                }
                else
                {
                    Console.WriteLine("Yes or No?");
                    answer = Console.ReadLine().ToLower();
                }
            }
            if (answer == ("yes"))
            {
                CheckIfEqual();
            }
            //Driver code to check if a number is even or odd with yes or no input
            Console.WriteLine("\n\nWould you like to check whether a number is even or odd?");
            Console.WriteLine("Yes or No?");
            answer = Console.ReadLine().ToLower();
            while (answer != "yes")
            {
                if (answer == "no")
                {
                    Console.WriteLine("That's unfortunate...");
                    break;
                }
                else
                {
                    Console.WriteLine("Yes or No?");
                    answer = Console.ReadLine().ToLower();
                }
            }
            if (answer == "yes")
            {
                EvenOrOdd();
            }
            //Driver code to check if a number is positive or negative with yes or no input
            Console.WriteLine("\n\nWould you like to check whether a number is positive or negative?");
            Console.WriteLine("Yes or No?");
            answer = Console.ReadLine().ToLower();
            while (answer != "yes")
            {
                if (answer == "no")
                {
                    Console.WriteLine("That's unfortunate...");
                    break;
                }
                else
                {
                    Console.WriteLine("Yes or No?");
                    answer = Console.ReadLine().ToLower();
                }
            }
            if (answer == "yes")
            {
                PositiveOrNegative();
            }
            //Driver code to check if the user if of voting age with yes or no input
            Console.WriteLine("\n\nWould you like to know if you are old enough to vote?");
            Console.WriteLine("Yes or No?");
            answer = Console.ReadLine().ToLower();
            while (answer != "yes")
            {
                if (answer == "no")
                {
                    Console.WriteLine("That's unfortunate...");
                    break;
                }
                else
                {
                    Console.WriteLine("Yes or No?");
                    answer = Console.ReadLine().ToLower();
                }
            }
            if (answer == "yes")
            {
                VotingAge();
            }
            //Driver code to check if a number is between -10 and 10 with yes or no input
            Console.WriteLine("\n\nWould you like to check if a number is between -10 and 10?");
            Console.WriteLine("Yes or No?");
            answer = Console.ReadLine().ToLower();
            while (answer != "yes")
            {
                if (answer == "no")
                {
                    Console.WriteLine("That's unfortunate...");
                    break;
                }
                else
                {
                    Console.WriteLine("Yes or No?");
                    answer = Console.ReadLine().ToLower();
                }
            }
            if (answer == "yes")
            {
                BetweenTheTens();
            }
            //Driver code to calculate a number's times table up to 12 with yes or no input
            Console.WriteLine("\n\nWould you like to calculate a number's times table up to 12?");
            Console.WriteLine("Yes or No?");
            answer = Console.ReadLine().ToLower();
            while (answer != "yes")
            {
                if (answer == "no")
                {
                    Console.WriteLine("That's unfortunate...");
                    break;
                }
                else
                {
                    Console.WriteLine("Yes or No?");
                    answer = Console.ReadLine().ToLower();
                }
            }
            if (answer == "yes")
            {
                OneThroughTwelveMultiplicationTable();
            }
        }
    }
}
