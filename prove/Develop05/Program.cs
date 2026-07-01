using System;

class Program
{
    static void Main(string[] args)
    {
     int points;
     List<Goal> tasks=new List<Goal>();
     int choice=0;
     
     while(choice!=6)
        {
      Console.WriteLine("Menu:");
      Console.WriteLine(" 1: List Goals");
      Console.WriteLine(" 2: Add goal");
      Console.WriteLine(" 3: Record Event");
      Console.WriteLine(" 4: Load Goals");
      Console.WriteLine(" 5: save Goals");
      Console.WriteLine(" 6: Exit");
      choice=int.Parse(Console.ReadLine());

      if(choice==1)
            {
                foreach(Goal goal in tasks)
                {
                    goal.Display();

                }

            }
      
        }

      if(choice==2)
        {
            Console.WriteLine("what type of goal do you want to add?");
            
        }


    }
}