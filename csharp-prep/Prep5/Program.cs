using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name=Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {    
        Console.Write("What is your favorite number? ");
        string numWord=Console.ReadLine();
       int num =int.Parse(numWord);
        return num;
    }

     static void PromptUserBirthYear(out int year)
    {    
        
        Console.Write("What is your Birth year? ");
        string yearWord=Console.ReadLine();
        year = int.Parse(yearWord);
        
    }

        static int Square(int num)
    {    
        num=num*num;
        return num;

    }

     static void DisplayResult(string name,int num,int year)
    {    
        int age;
        age = 2026-year;

        Console.WriteLine($"{name}, the square of your number is {num}");
        Console.WriteLine($"{name}, This year you will be turning {age} years old");
        
        
    }

    static void Main(string[] args)
    {   
        int year;
        string name;
        int num;

        DisplayWelcome();
        name=PromptUserName();
        num=PromptUserNumber();
        PromptUserBirthYear(out year);
        num=Square(num);
        DisplayResult(name,num,year);

        





    }
}