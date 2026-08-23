using System;

class TriangleIdentifier
{
    static void Main()
    {
        Console.WriteLine("Welcome to Stevo's Triangle Identifier");
        Console.WriteLine("Enter the three sides of the triangle and I'll help you identify the type of triangle you have.");

        try
        {
            Console.Write("Enter the value of the first side: ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of the second side: ");
            double sideB = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of the third side: ");
            double sideC = double.Parse(Console.ReadLine());

            if (sideA == sideB && sideB == sideC)
            {
                Console.WriteLine("Your triangle is an Equilateral triangle");
            }
            else if (sideA == sideB || sideB == sideC || sideA == sideC)
            {
                Console.WriteLine("Your triangle is an Isosceles triangle");
            }
            else if (sideA != sideB && sideB != sideC && sideA != sideC)
            {
                Console.WriteLine("Your triangle is a Scalene triangle");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid dimensions");
        }
    }
}