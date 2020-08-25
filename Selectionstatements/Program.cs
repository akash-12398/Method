using System;

namespace Selectionstatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you can guess the correct number!");
            Console.WriteLine("What is the upper limit for the range of the number?");

            var userResponse = Console.ReadLine();

            var upperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(1, upperLimit);

            Console.WriteLine("Go ahead and guess");

            var guess = int.Parse(Console.ReadLine());

            if(guess > number)
            {
                Console.WriteLine("Sorry, you guessed too high");
            }
            else if(guess > number)
            {
                Console.WriteLine("Sorry, you guessed too low");
            }
            else
            {
                Console.WriteLine("Correct");
            }



        }
    }
}
