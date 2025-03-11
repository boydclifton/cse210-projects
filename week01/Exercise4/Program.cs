using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input = -1;
        Console.WriteLine("Please add numbers to a list one at a time. Type 0 to finish");
        do 
        {
        Console.Write("Enter a number: ");
        input = int.Parse(Console.ReadLine());
        if (input != 0)
        {
        numbers.Add(input);
        }
        } while (input != 0);


        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum) / numbers.Count; 
        Console.WriteLine($"The Average is {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max) 
            {
                max = number;
            }
        }
        Console.WriteLine($"The max number is {max}");
        Console.WriteLine(numbers);
    }
}
    