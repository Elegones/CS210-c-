using System;

class Program
{
    static void Main(string[] args)
    {
        Activity  activity= new Activity(5);

        Breathing  inhale = new Breathing("Hello","Bye",5);
        

       inhale.BreathingLoop();
    }
}