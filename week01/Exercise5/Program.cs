using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        int favNumberSquared = FavNumberSquared(favNumber);
        DisplayResult(name, favNumberSquared);



        
        
        
        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int FavNumberSquared(int favNumber)
        {
            int favNumberSquared = favNumber * favNumber;
            return favNumberSquared;
        }

        static void DisplayResult(string name, int favNumberSquared)
        {
            Console.WriteLine($"{name}, the square of your number is {favNumberSquared}.");
        }


    //    static void DisplayMessage()
    //    {
    //     Console.WriteLine("Hello World!");
    //    }

    //    static void DisplayPersonalMessage(string userName)
    //    {
    //     Console.WriteLine($"Hello {userName}");
    //    }

    //    static int AddNumbers(int first, int second)
    //    {
    //     int sum = first + second; 
    //     return sum;
    //    }
    }
}