using System;

class Program
{
    static void Main(string[] args)
    {
    string intro;
    string topic;
    string outro;
    int time;
    int choice=0;
    TimeSpan overallTime;
    DateTime startTimes = DateTime.Now;
    
    

    do
    {
      
      Console.WriteLine("Menu:");
      Console.WriteLine(" 1: Breathing Activity");
      Console.WriteLine(" 2: Reflecting Activity");
      Console.WriteLine(" 3: Listing Activity");
      Console.WriteLine(" 5: exit");
      choice=int.Parse(Console.ReadLine());
      Console.Clear();


      if(choice==1)
      {
        
        topic="Breathing";
        Console.WriteLine($"Thank you for chosing the {topic} activity");
        intro=$" In this activatiy we will practice controling our breathing to relax";
        outro="Thank you for particpating in the ";
        Console.WriteLine("how long would you like this activity to run for (in seconds)");
        time=int.Parse(Console.ReadLine());
        Console.Clear();
        Breathing  inhale = new Breathing( intro,  outro, time, topic);
        inhale.BreathingLoop();
        Console.Clear();

      }

      if(choice==2)
      {
        topic="Reflecting";
        Console.WriteLine($"Thank you for chosing the {topic} activity");
        intro=$" In this activatiy we will practice Reflecting on a prompt, this will help you rember what youve been through and how it has changed you.";
        outro="Thank you for particpating in the ";
        Console.WriteLine("how long would you like this activity to run for (in seconds)");
        time=int.Parse(Console.ReadLine());

        Reflecting reflect=new Reflecting( intro,  outro, time, topic);
        reflect.ReflectingLoop();
        Console.Clear();

      }

      if(choice==3)
      {
        topic="Listing";
        Console.WriteLine($"Thank you for chosing the {topic} activity");
        intro=$" In this activity you  will be given a prompt to respond to as much as possible in the given time, this will help you think about the experiance you have went through.";
        outro="Thank you for particpating in the ";
        Console.WriteLine("how long would you like this activity to run for (in seconds)");
        time=int.Parse(Console.ReadLine());
        Listing list = new Listing( intro,  outro, time, topic);
        list.ListingLoop();
        Console.Clear();

      }

    }while(choice!=5);

    DateTime currentTimes=DateTime.Now;
    overallTime=currentTimes-startTimes;
    Console.WriteLine($"overall time spent doing activites {overallTime} Hours:minutes:seconds.millaseconds ");

     
    }
}