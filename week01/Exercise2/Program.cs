using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your grade percentage for this semester? ");
        string valueFromUser = Console.ReadLine();
        int percent = int.Parse(valueFromUser);
        string letter = "";
        string symbol = "";
        


        if (percent >= 90)
        {
            letter = "A";
        }

        else if (percent >= 80)
        {
            letter = "B";
        }

        else if (percent >= 70)
        {
            letter = "C";
        }

        else if (percent >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        int lastDigit = percent % 10;

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

            else
            {
                symbol = "";
            }
        }

        if (letter == "A")
        {
            if (lastDigit <= 3)
            {
                symbol = "-";
            }

            else if (lastDigit > 3)
            {
                symbol = "";
            }
        }



        Console.WriteLine($"Your letter grade is {letter}{symbol}");

        if (percent >= 70)
        {
            Console.WriteLine("You have passed the class");
        }

        else
        {
            Console.WriteLine("You have not passed the class");
        }
    }
}