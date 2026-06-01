using System;

class Program
{
    static void Main(string[] args)
    {
        Assignments homeWork= new Assignments("Ethan","CSE");
       Console.WriteLine( homeWork.Getsummary());

       MathAssignment mathHw =new MathAssignment("Ethan","CSE","chapter 1.2-1.3","5-10");
       Console.WriteLine(mathHw.Getsummary());
       Console.WriteLine(mathHw.GetHomeworkList());

       WritingAssignment WriteHw =new WritingAssignment("Ethan","English","Book ");
       Console.WriteLine(WriteHw.Getsummary());
       Console.WriteLine(WriteHw.GetWritingAssignment());
       
       
           
       
       


    }
}