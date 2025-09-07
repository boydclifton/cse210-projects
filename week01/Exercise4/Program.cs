using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int userNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}.");


        float average = ((float)sum) / numbers.Count();



        Console.WriteLine($"The average is {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max number is {max}");

        int smallestNumber = 100000;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestNumber)
            {
                smallestNumber = number;
            }
        }
        Console.WriteLine($"The smallest positive number is {smallestNumber}");

        numbers.Sort();
        Console.WriteLine("The sorted list is shown below: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        




















    }
}
    