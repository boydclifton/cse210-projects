using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response;

        do 
        {Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guessNumber = -1; 

        while (magicNumber != guessNumber)
        {
            Console.WriteLine("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
            
            if (guessNumber < magicNumber)
        {
            Console.WriteLine("Higher");
        }
            else if (guessNumber > magicNumber)
        {
            Console.WriteLine("Lower");

        }}

        Console.WriteLine("You guessed the magic number!");
        Console.WriteLine("Would you like to play again?");
        response = Console.ReadLine();
        } while (response == "yes");

        Console.WriteLine("Thanks for playing!");



        

    }
}