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

    do
    {
      
      Console.WriteLine("Menu:");
      Console.WriteLine(" 1: Breathing Activity");
      Console.WriteLine(" 2: Reflecting Activity");
      Console.WriteLine(" 3: Listing Activity");
      Console.WriteLine(" 5: exit");
      choice=int.Parse(Console.ReadLine());


      if(choice==1)
      {
        Console.Clear();
        

        topic="Breathing";
        Console.WriteLine($"Thank you for chosing the {topic} activity");
        intro=$"In this activatiy we will practice controling our breathing to relax";
        outro="Thank you for particpating in the ";
        Console.WriteLine("how long would you like this activity to run for");
        time=int.Parse(Console.ReadLine());

        Breathing  inhale = new Breathing( intro,  outro, time, topic);
        inhale.BreathingLoop();

      }

      if(choice==2)
      {
        Console.Clear();
        

        topic="Reflecting";
        Console.WriteLine($"Thank you for chosing the {topic} activity");
        intro=$"In this activatiy we will practice Reflecting on a prompt";
        outro="Thank you for particpating in the ";
        Console.WriteLine("how long would you like this activity to run for");
        time=int.Parse(Console.ReadLine());

        Reflecting reflect=new Reflecting( intro,  outro, time, topic);
        reflect.ReflectingLoop();

      }

      if(choice==3)
      {
        Console.Clear();
        

        topic="Listing";
        Console.WriteLine($"Thank you for chosing the {topic} activity");
        intro=$"In this activatiy we will be given a prompt and then list respose to prompt.";
        outro="Thank you for particpating in the ";
        Console.WriteLine("how long would you like this activity to run for");
        time=int.Parse(Console.ReadLine());
        Listing list = new Listing( intro,  outro, time, topic);
        list.ListingLoop();

        

      }

    }while(choice!=5);

    


      //Activity  activity= new Activity(5);
      //activity.WaitingAnimation();
      /*  Activity  activity= new Activity(5);

        Breathing  inhale = new Breathing(". In this activity we will be controling our breathing, please follow along","Thank you for particpating in the",11,"breathing");
        

       inhale.BreathingLoop();
       */

       //Reflecting reflect=new Reflecting(". In this activity we will be reflecting, please follow along","Thank you for particpating in the",40,"reflectign");
       //reflect.ReflectingLoop();
       //Listing list = new Listing(". In this activity we will be Listing, please follow along","Thank you for particpating in the",20,"Listing");
    }
}