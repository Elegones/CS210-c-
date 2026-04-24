using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your first name? ");
       string first= Console.ReadLine();

        Console.Write("what is your Last name? ");
       string Last = Console.ReadLine();

        Console.WriteLine($"Your name is {Last}, {first} {Last}.");

    }
}