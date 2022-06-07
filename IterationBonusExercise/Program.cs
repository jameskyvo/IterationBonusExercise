using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationBonusExercise
{
    internal class Program
    {
        static void PrintMinus1Kto1K()
        {
            for (var i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Print3to999()
        {
            for (var i = 3; i <= 999; i = i + 3)
            {
                Console.WriteLine(i);
            }
        }
        static void CheckEquality()
        {
            Console.WriteLine("What is your first number?");
            var firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your second number?");
            var secondNum = int.Parse(Console.ReadLine());
            bool isEqual = firstNum == secondNum;
            Console.WriteLine($"It is {isEqual} that {firstNum} and {secondNum} are equal.");
        }
        static void CheckIfEven()
        {
            var givenNumber = int.Parse(Console.ReadLine());
            var isEven = (givenNumber % 2 == 0) ? $"{givenNumber} is even" : $"{givenNumber} is odd";
            Console.WriteLine(isEven);
        }
        static void CheckSign()
        {
            int givenNumber = int.Parse(Console.ReadLine());
            if (givenNumber > 0)
            {
                Console.WriteLine($"{givenNumber} is positive.");
            }
            else if (givenNumber < 0)
            {
                Console.WriteLine($"{givenNumber} is negative.");
            }
            else
            {
                Console.WriteLine("0 is neither positive nor negative.");
            }
        }
        static void CheckVotingAge()
        {
            var userAge = int.Parse(Console.ReadLine());
            if (userAge >= 18)
            {
                Console.WriteLine("You're old enough to vote! Don't do anything stupid, now.");
            }
            else
            {
                Console.WriteLine("Go back to preschool!");
            }
        }
        static void CheckNumberRange()
        {
            int givenNumber = int.Parse(Console.ReadLine());
            if (givenNumber >= -10 && givenNumber <= 10)
            {
                Console.WriteLine($"{givenNumber} is in between -10 and 10! :)");
            }
            else
            {
                Console.WriteLine($"{givenNumber} is not in that range. >:(");
            }
        }

        static void DisplayMultiplicationTable()
        {
            int givenNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{givenNumber} times {i} is {givenNumber * i}");
            }
            Console.WriteLine("Better start studying!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Counting to One Thousand from Negative One Thousand:");
            PrintMinus1Kto1K();

            Console.WriteLine("Counting to 999 by threes:");
            Print3to999();

            Console.WriteLine("Give me two numbers and I will see if they are equal.");
            CheckEquality();

            Console.WriteLine("Give me a number and I will check if it is even.");
            CheckIfEven();

            Console.WriteLine("Insert a number and I will tell you whether it is positive or negative.");
            CheckSign();

            Console.WriteLine("It's time to vote! How old are you?");
            CheckVotingAge();

            Console.WriteLine("Give me a number and I will tell you if it is in between -10 to 10.");
            CheckNumberRange();

            Console.WriteLine("It's time to memorize your multiplication tables. Give me a number and I'll tell you its multiples up to 12!");
            DisplayMultiplicationTable();
        }
    }
}
