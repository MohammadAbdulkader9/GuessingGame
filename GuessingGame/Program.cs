using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** Guessing Game *****");
            Console.WriteLine("Guess Numbers 1-10");
            Console.WriteLine("Life: 3");
            Console.WriteLine("-------------------------");

            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 10);

            int life = 3;

            int enteredNumber;

            do
            {
                Console.Write("Enter a Number: ");
                enteredNumber = int.Parse(Console.ReadLine());

                if (enteredNumber > randomNumber)
                {
                    Console.WriteLine("High");
                }
                else if (enteredNumber < randomNumber)
                {
                    Console.WriteLine("Low");
                }
                else if (enteredNumber == randomNumber)
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Try Again");
                }

                life--;

                if (life == 0)
                    break;

                Console.WriteLine("Remain life: " + life);
                Console.WriteLine("-------------------------");
            } while (enteredNumber != randomNumber);
            Console.WriteLine("-------------------------");
            Console.WriteLine($"random number is {randomNumber}");
        }
    }
}
