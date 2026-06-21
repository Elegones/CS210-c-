using System;

class Program
{
    static void Main(string[] args)
    {
    string intro;
    string topic;
    string outro;
    int time;
    string prompt="";
    int choice=0;

    do
    {
      Console.WriteLine("Menu:");
      Console.WriteLine(" 1: Breathing Activity");
      Console.WriteLine(" 2: Reflecting Activity");
      Console.WriteLine(" 3: Listing Activity");
      Console.WriteLine(" 5: exit");


      if(choice==1)
      {
        topic="Breathing activity";
        intro=$"In this activatiy we will practice controling our breathing to relax";

      }

    }while(choice!=5);

    


      Activity  activity= new Activity(5);
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