using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please type the grade percentage you got for this course: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string symbol = "";
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        int lastDigit = grade % 10;
        if (letter != "F")
        {
            if (lastDigit >= 7)
            {
                symbol = "+";
            }

            else if (lastDigit <= 3)
            {
                symbol = "-";
            }
        }

        if (letter == "A" && symbol == "+")
        {
            symbol = "";
        }
        


        if (grade >= 70)
        {
            Console.WriteLine("Congratulatins, you passed the class!");
        }

        else
        {
            Console.WriteLine("You did not pass the class this year");
        }

        Console.WriteLine($"You received the letter grade of {letter}{symbol} for the semester.");
    }
}