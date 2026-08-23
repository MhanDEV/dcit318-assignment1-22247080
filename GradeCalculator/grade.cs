using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a grade between 0 and 100: ");
        double grade = Convert.ToDouble(Console.ReadLine());

        if (grade >= 90)
        {
            Console.WriteLine("Your grade is an A");
        }
        else if (grade >= 80 && grade < 90)
        {
            Console.WriteLine("Your grade is a B");
        }
        else if (grade >= 70 && grade < 80)
        {
            Console.WriteLine("Your grade is a C");
        }
        else if (grade >= 60 && grade < 70)
        {
            Console.WriteLine("Your grade is a D");
        }
        else
        {
            Console.WriteLine("Your grade is an F");
        }
        Console.Write("Thanks for using my grade calculator system");
    }
}