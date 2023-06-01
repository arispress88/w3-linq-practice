using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("The numbers which produce the remainder 0 after divided by 2 are:");

        // Part 1 and 2... using Linq to filter numbers that produce a remainder of 0 when divided by 2.
        var numbers = Enumerable.Range(0, 9).Where(num => num % 2 == 0);

        // Part 3 prints filtered numbers
        Console.WriteLine(string.Join(" ", numbers));
    }
}