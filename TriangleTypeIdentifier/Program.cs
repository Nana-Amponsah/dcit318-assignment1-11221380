using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter side A: ");
        int a = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter side B: ");
        int b = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter side C: ");
        int c = int.Parse(Console.ReadLine() ?? "0");

        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Triangle type: Equilateral");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Triangle type: Isosceles");
            }
            else
            {
                Console.WriteLine("Triangle type: Scalene");
            }
        }
        else
        {
            Console.WriteLine("The sides do not form a valid triangle.");
        }
    }
}
