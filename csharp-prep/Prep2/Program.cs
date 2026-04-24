using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello what percetage grade did you get? ");
        string gradeString =Console.ReadLine();
        int gradeNum= int.Parse(gradeString);
        string letterGrade;

        if(gradeNum>=90)
        {
            letterGrade="A";
        }
        else if(gradeNum>=80)
        {
            letterGrade="B";
        }
         else if(gradeNum>=70)
        {
            letterGrade="C";
        }
        else if(gradeNum>=60)
        {
            letterGrade="D";
        }
        else
        {
            letterGrade="F";
        }
        Console.Write($"Your grade is A {letterGrade} ");

        if(gradeNum>=70)
        {
            Console.WriteLine("You passed.");
        }
        else 
        {
            Console.WriteLine("You failed, better luck next time.");
        }
    
    }
}