using System;

class Program
{
    private const int MAX_CHARACTERS = 140;

    static void Main()
    {
        Console.WriteLine("Enter your message:");
        string message = Console.ReadLine();

        if (message.Length > MAX_CHARACTERS)
        {
            Console.WriteLine("Rejected");
        }
        else
        {
            Console.WriteLine("Posted");
        }
    }
}
