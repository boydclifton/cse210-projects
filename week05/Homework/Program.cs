using System;


class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Boyd Stinnett", "Exponents");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment("Boyd Stinett", "Exponents", "22", "8-25");
        Console.WriteLine($"{math1.GetSummary()}, {math1.GetHomeworkList()}");

        WritingAssignment writing1 = new WritingAssignment("Boyd Stinnett", "Victorian Literature", "Understanding 'The Count of Monte Cristo'");
        Console.WriteLine($"{writing1.GetSummary()} - {writing1.GetWritingInformation()}");
        
    }

}

