using System;

class TicketProgram
{
    static void Main()
    {
        Console.WriteLine("Welcome to Stevo's Price calculator");

        int age = int.Parse(Console.ReadLine());
        int price;

        if (age <= 0)
        {
            Console.WriteLine("Please enter a valid age");
            return;
        }
        else if (age >= 65 || age <= 12)
        {
            price = 7;
        }
        else
        {
            price = 10;
        }

        Console.WriteLine($"Your movie ticket price is GHC{price}");
    }
}
