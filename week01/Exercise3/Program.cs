using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string anotherTry = "yes";
        while (anotherTry.ToLower() == "yes")
        {
            int guessQuantity = 0;
            int guessNumber = -1;
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            while (guessNumber != magicNumber)
            {
                Console.Write("What is your guess for the magic number? ");
                guessNumber = int.Parse(Console.ReadLine());
                guessQuantity++;

                if (magicNumber > guessNumber)
                {
                    Console.WriteLine("You need to guess higher! ");
                }

                else if (magicNumber < guessNumber)
                {
                    Console.WriteLine("You need to guess lower!");
                }

                else
                {
                    Console.WriteLine("You guessed the magic number!");
                }
            }

            Console.WriteLine($"It took you {guessQuantity} guesses.");
            Console.Write("Would you like to play again? [yes/no] ");
            anotherTry = Console.ReadLine();

        }



    }
}