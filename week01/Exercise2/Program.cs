using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";



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
        string symbol = "";
        if (lastDigit >= 7 && letter != "A" && letter != "F")
        {
            symbol = "+";
        }
        else if (lastDigit < 3 && letter != "A" && letter != "F")
        {
            symbol = "-";
        }


        Console.WriteLine($"You have earned the grade of {letter}{symbol}");

    }
}